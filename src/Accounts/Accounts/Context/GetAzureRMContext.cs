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
using Microsoft.Azure.Commands.Common.Authentication.Models;
using Microsoft.Azure.Commands.Profile.Models;
// TODO: Remove IfDef
#if NETSTANDARD
using Microsoft.Azure.Commands.Profile.Models.Core;
#endif
using Microsoft.Azure.Commands.ResourceManager.Common;
using System.Management.Automation;
using System;
using System.Linq;
using System.Collections.ObjectModel;
using Microsoft.Azure.Commands.Profile.Properties;
using System.Collections.Generic;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.Azure.Commands.Profile.Common;

namespace Microsoft.Azure.Commands.Profile
{
    /// <summary>
    /// Cmdlet to get current context.
    /// </summary>
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "Context", DefaultParameterSetName = SubscriptionParameterSet)]
    [OutputType(typeof(PSAzureContext))]
    public class GetAzureRMContextCommand : AzureRMCmdlet
    {
        public const string ListAllParameterSet = "ListAllContexts", GetSingleParameterSet = "GetSingleContext", 
            SubscriptionParameterSet = "GetBySubscription", NameParameterSet = "GetByName";
        /// <summary>
        /// Gets the current default context.
        /// </summary>
        protected override IAzureContext DefaultContext
        {
            get
            {
                if (DefaultProfile == null || DefaultProfile.DefaultContext == null)
                {
                    return null;
                }

                return DefaultProfile.DefaultContext;
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = ListAllParameterSet, HelpMessage = "List all available contexts in the current session.")]
        public SwitchParameter ListAvailable { get; set; }

        [Parameter(Position = 0, Mandatory = true, ParameterSetName = NameParameterSet, HelpMessage = "The name of the needed context.")]
        [ValidateNotNullOrEmpty]
        [ContextCompleter]
        [SupportsWildcards]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = SubscriptionParameterSet, HelpMessage = "List contexts in the current session for the given subscription name or id.")]
        [SupportsWildcards]
        [ContextCompleter]
        public string Subscription { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = SubscriptionParameterSet, HelpMessage = "List contexts in the current session for the given subscription name or id.")]
        [SupportsWildcards]
        [ContextCompleter]
        public string Account { get; set; }

        public override void ExecuteCmdlet()
        {
            // If no context is found, return
            if (DefaultContext == null)
            {
                return;
            }

            var profile = DefaultProfile as AzureRmProfile;
            var context = DefaultContext;
            string name = null;

            if (this.IsParameterBound(c => c.Name))
            {
                name = Name;
            }


            var container = DefaultProfile as AzureRmProfile;
            IEnumerable<KeyValuePair<string, IAzureContext>> contexts = container?.Contexts;
            if (contexts.Any())
            {
                contexts = contexts
                    ?.Filter(nameof(Name), Name, MyInvocation.BoundParameters, nameof(Name), (pair) => pair.Key)
                    ?.Filter(nameof(Subscription), Subscription, MyInvocation.BoundParameters, nameof(Subscription), (pair) => pair.Value?.Subscription?.Name, pair2 => pair2.Value?.Subscription?.Id)
                    ?.Filter(nameof(Account), Account, MyInvocation.BoundParameters, nameof(Account), (pair) => pair.Value?.Account?.Id);
            }

            if (ListAvailable.IsPresent || this.IsParameterBound(c=> c.Account) 
                || this.IsParameterBound(c => c.Subscription) || this.IsParameterBound(c => c.Name))
            {
                if (contexts != null && contexts.Any())
                {
                    foreach (var ctx in contexts)
                    {
                        WriteContext(ctx.Value, ctx.Key);
                    }
                }

                return;
            }

            WriteContext(context, (profile)?.DefaultContextKey);
        }

        void WriteContext(IAzureContext azureContext, string name)
        {
            var context = new PSAzureContext(azureContext);
            if (name != null)
            {
                context.Name = name;
            }

            // Don't write the default (empty) context to the output stream
            if (context.Account == null &&
                context.Environment == null &&
                context.Subscription == null &&
                context.Tenant == null)
            {
                return;
            }

            WriteObject(context);
        }

        public object GetDynamicParameters()
        {
            var parameters = new RuntimeDefinedParameterDictionary();
            AzureRmProfile localProfile = DefaultProfile as AzureRmProfile;
            if (localProfile != null && localProfile.Contexts != null && localProfile.Contexts.Count > 0)
            {
                var nameParameter = new RuntimeDefinedParameter(
                "Name", typeof(string),
                    new Collection<Attribute>()
                    {
                        new ParameterAttribute { Position =0, Mandatory=false, HelpMessage="The name of the context", ParameterSetName=GetSingleParameterSet },
                        new ValidateSetAttribute((DefaultProfile as AzureRmProfile).Contexts.Keys.ToArray())
                    }
                );
                parameters.Add(nameParameter.Name, nameParameter);
            }

            return parameters;
        }
    }
}
