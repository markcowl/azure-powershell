// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core;
using Microsoft.Azure.Commands.Common.Authentication.Models;
using Microsoft.Azure.Commands.Common.Authentication.ResourceManager;
using Microsoft.Azure.Commands.Profile.Common;
using Microsoft.Azure.Commands.Profile.Models;
// TODO: Remove IfDef
#if NETSTANDARD
using Microsoft.Azure.Commands.Profile.Models.Core;
#endif
using Microsoft.Azure.Commands.Profile.Properties;
using Microsoft.Azure.Commands.ResourceManager.Common;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Profile
{
    /// <summary>
    /// Cmdlet to change current Azure context.
    /// </summary>
    [Cmdlet(VerbsOther.Use, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "Context", DefaultParameterSetName = ContextParameterSet,SupportsShouldProcess = true)]
    [OutputType(typeof(PSObject))]
    public class UseAzureRMContextCommand : AzureRMCmdlet
    {
        private const string SubscriptionParameterSet = "Subscription";
        private const string ContextParameterSet = "Context";


        [Parameter(Mandatory = true, HelpMessage = "The script to run under the given context", Position = 0)]
        [ValidateNotNullOrEmpty]
        public ScriptBlock ScriptBlock { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = ContextParameterSet, HelpMessage = "The name of the needed context.")]
        [ValidateNotNullOrEmpty]
        [ContextCompleter]
        [SupportsWildcards]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = SubscriptionParameterSet, HelpMessage = "The subscription containing the needed context.")]
        [ValidateNotNullOrEmpty]
        [ContextCompleter]
        [SupportsWildcards]
        public string Subscription { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = SubscriptionParameterSet, HelpMessage = "The account name containing the needed context.")]
        [ValidateNotNullOrEmpty]
        [ContextCompleter]
        [SupportsWildcards]
        public string Account { get; set; }


        public override void ExecuteCmdlet()
        {
            string name = null;

            if (this.IsParameterBound(c => c.Name))
            {
                name = Name;
            }


            var container = DefaultProfile as AzureRmProfile;
            if (container != null)
            {
                var contexts = container.Contexts
                    ?.Filter(nameof(Name), Name, MyInvocation.BoundParameters, nameof(Name), (pair) => pair.Key)
                    ?.Filter(nameof(Subscription), Subscription, MyInvocation.BoundParameters, nameof(Subscription), (pair) => pair.Value?.Subscription?.Name, pair2 => pair2.Value?.Subscription?.Id)
                    ?.Filter(nameof(Account), Account, MyInvocation.BoundParameters, nameof(Account), (pair) => pair.Value?.Account?.Id);

                if (contexts.Count() == 1)
                {
                    name = contexts.First().Key;
                }
            }

            AzureRmProfile profile = new AzureRmProfile();
            TryCopyProfile(DefaultProfile, profile);
            if (!string.IsNullOrWhiteSpace(name))
            {
                profile.DefaultContextKey = name;
            }

            var defaultParameterValues = new Hashtable();
            defaultParameterValues.Add("*-Az*:DefaultProfile", profile);
            defaultParameterValues.Add("Set-AzContext:Context", profile.DefaultContext);
            WriteObject(ScriptBlock.InvokeWithContext(new Dictionary<string, ScriptBlock>(), new List<PSVariable> { new PSVariable("PSDefaultParameterValues", defaultParameterValues) }), true);
        }

        bool TryCopyProfile(IAzureContextContainer source, AzureRmProfile target)
        {
            var sourceProfile = source as AzureRmProfile;
            if (sourceProfile != null && !this.IsParameterBound(c => c.DefaultProfile))
            {
                return target.TryCopyProfile(sourceProfile);
            }

            foreach (var environment in source.Environments)
            {
                if (!target.EnvironmentTable.ContainsKey(environment.Name))
                {
                    var environmentCopy = new AzureEnvironment();
                    environmentCopy.CopyFrom(environment);
                    target.EnvironmentTable.Add(environmentCopy.Name, environmentCopy);
                }
            }

            string contextName;
            var context = new AzureContext();
            context.CopyFrom(source.DefaultContext);
            return target.TryAddContext(context, out contextName) &&
            target.TrySetDefaultContext(contextName);
        }
    }
}
