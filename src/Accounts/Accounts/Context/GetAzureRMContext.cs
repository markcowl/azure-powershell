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

namespace Microsoft.Azure.Commands.Profile
{
    /// <summary>
    /// Cmdlet to get current context.
    /// </summary>
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "Context", DefaultParameterSetName = GetSingleParameterSet)]
    [OutputType(typeof(PSAzureContext))]
    public class GetAzureRMContextCommand : AzureRMCmdlet, IDynamicParameters
    {
        public const string ListAllParameterSet = "ListAllContexts", GetSingleParameterSet = "GetSingleContext", SubscriptionParameterSet = "GetBySubscription";
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

        [Parameter(Mandatory = false, ParameterSetName = ListAllParameterSet, HelpMessage = "List contexts in the current session for the given subscription name or id.")]
        [Parameter(Mandatory = true, ParameterSetName = SubscriptionParameterSet, HelpMessage = "List contexts in the current session for the given subscription name or id.")]
        [SupportsWildcards]
        public string Subscription { get; set; }

        public override void ExecuteCmdlet()
        {
            // If no context is found, return
            if (DefaultContext == null)
            {
                return;
            }

            var profile = DefaultProfile as AzureRmProfile;
            var context = DefaultContext;
            Func<KeyValuePair<string, IAzureContext>, bool> contextFilter = c => true;
            if (this.IsParameterBound(c => c.Subscription))
            {
                var matcher = new WildcardPattern(Subscription);
                contextFilter = ctx => matcher.IsMatch(ctx.Value?.Subscription?.Id) 
                || matcher.IsMatch(ctx.Value?.Subscription?.Name);
            }

            if (ListAvailable.IsPresent || this.IsParameterBound(c => c.Subscription))
            {
                if (profile != null && profile.Contexts.Any(contextFilter))
                {
                    foreach (var ctx in profile.Contexts.Where(contextFilter))
                    {
                        WriteContext(ctx.Value, ctx.Key);
                    }
                }

                return;
            }

            if (profile != null && MyInvocation.BoundParameters.ContainsKey("Name"))
            {
                var key = MyInvocation.BoundParameters["Name"] as string;
                if (profile.Contexts != null && profile.Contexts.ContainsKey(key))
                {
                    context = profile.Contexts[key];
                    WriteContext(context, key);
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
