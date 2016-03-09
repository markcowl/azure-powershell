﻿// ----------------------------------------------------------------------------------
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

using Microsoft.Azure.Commands.Resources.Models;
using System.Management.Automation;
using ProjectResources = Microsoft.Azure.Commands.Resources.Properties.Resources;

namespace Microsoft.Azure.Commands.Resources
{
    using System.Linq;

    /// <summary>
    /// Removes a new resource group.
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "AzureRmResourceGroup", SupportsShouldProcess = true, 
        ConfirmImpact = ConfirmImpact.High, DefaultParameterSetName = ResourceGroupNameParameterSet), 
    OutputType(typeof(bool))]
    public class RemoveAzureResourceGroupCommand : ResourcesBaseCmdlet
    {
        /// <summary>
        /// List resources group by name parameter set.
        /// </summary>
        internal const string ResourceGroupNameParameterSet = "Lists the resource group based in the name.";

        /// <summary>
        /// List resources group by Id parameter set.
        /// </summary>
        internal const string ResourceGroupIdParameterSet = "Lists the resource group based in the Id.";

        [Alias("ResourceGroupName")]
        [Parameter(Mandatory = true, ParameterSetName = ResourceGroupNameParameterSet, ValueFromPipelineByPropertyName = true, HelpMessage = "The name of the resource group.")]
        [ValidateNotNullOrEmpty]
        public string Name {get; set;}

        [Alias("ResourceGroupId", "ResourceId")]
        [Parameter(Mandatory = true, ParameterSetName = ResourceGroupIdParameterSet, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group Id.")]
        [ValidateNotNullOrEmpty]
        public string Id { get; set; }
        
        public override void ExecuteCmdlet()
        {
            Name = Name ?? ResourceIdentifier.FromResourceGroupIdentifier(this.Id).ResourceGroupName;

            ConfirmAction(
                ProjectResources.RemoveResourceGroupMessage,
                Name,
                () => ResourcesClient.DeleteResourceGroup(Name));
        }
    }
}