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

using Microsoft.Azure.Commands.Common.Authentication.Models;
using Microsoft.Azure.Commands.Profile.Common;
using Microsoft.Azure.Commands.Profile.Models;
// TODO: Remove IfDef
#if NETSTANDARD
using Microsoft.Azure.Commands.Profile.Models.Core;
#endif
using Microsoft.Azure.Commands.Profile.Properties;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Profile.Context
{
    [Cmdlet("Select", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "Context", SupportsShouldProcess = true, DefaultParameterSetName = InputObjectParameterSet)]
    [OutputType(typeof(PSAzureContext))]
    public class SelectAzureRmContext : AzureContextModificationCmdlet
    {
        public const string InputObjectParameterSet = "SelectByInputObject";
        public const string ContextNameParameterSet = "SelectByName";
        public const string ContextSelectParameterSet = "SelectByAccountSub";
        [Parameter(Mandatory =true, ParameterSetName = InputObjectParameterSet, ValueFromPipeline =true, HelpMessage ="A context object, normally passed through the pipeline.")]
        [ValidateNotNullOrEmpty]
        public PSAzureContext InputObject { get; set; }

        [Parameter(Position=0, Mandatory = true, ParameterSetName = ContextNameParameterSet, HelpMessage = "The name of the needed context.")]
        [ValidateNotNullOrEmpty]
        [ContextCompleter]
        [SupportsWildcards]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = ContextSelectParameterSet, HelpMessage = "The subscription containing the needed context.")]
        [ValidateNotNullOrEmpty]
        [ContextCompleter]
        [SupportsWildcards]
        public string Subscription { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = ContextSelectParameterSet, HelpMessage = "The account name containing the needed context.")]
        [ValidateNotNullOrEmpty]
        [ContextCompleter]
        [SupportsWildcards]
        public string Account { get; set; }

        public object GetDynamicParameters()
        {
            var parameters = new RuntimeDefinedParameterDictionary();
            RuntimeDefinedParameter nameParameter;
            if (TryGetExistingContextNameParameter("Name", ContextNameParameterSet, out nameParameter))
            {
                parameters.Add(nameParameter.Name, nameParameter);
            }

            return parameters;
        }

        public override void ExecuteCmdlet()
        {
            string name = null;
            if (ParameterSetName == InputObjectParameterSet)
            {
                    name = InputObject?.Name;
            }

            if (this.IsParameterBound(c=> c.Name))
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

            if (!string.IsNullOrWhiteSpace(name))
            {
                ConfirmAction(Resources.SelectContextPrompt, "Context",
                    () =>
                    {
                        if (name != null)
                        {
                            ModifyContext((profile, client) =>
                            {
                                client.TrySetDefaultContext(name);
                                var context = new PSAzureContext(profile.DefaultContext);
                                context.Name = profile.DefaultContextKey;
                                WriteObject(context);
                            });
                        }
                    });
            }
        }
    }
}
