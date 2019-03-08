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
        private const string SubscriptionObjectParameterSet = "SubscriptionObject";
        private const string TenantObjectParameterSet = "TenantObject";
        private const string TenantNameParameterSet = "TenantNameOnly";


        [Parameter(Mandatory = true, HelpMessage = "The script to run under the given context", Position = 0)]
        [ValidateNotNullOrEmpty]
        public ScriptBlock ScriptBlock { get; set; }


        public override void ExecuteCmdlet()
        {
            AzureRmProfile profile = new AzureRmProfile();
            TryCopyProfile(DefaultProfile, profile);
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
