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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Management.Automation;
using System.Security.Permissions;
using Microsoft.Azure.Commands.Automation.Common;
using Microsoft.Azure.Commands.Automation.Model;
using Microsoft.Azure.Commands.Automation.Properties;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Automation.Cmdlet
{
    /// <summary>
    /// Updates configuration on the dsc node.
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "AzureRmAutomationDscNode", 
        SupportsShouldProcess=true, ConfirmImpact=ConfirmImpact.High)]
    [OutputType(typeof(DscNode))]
    public class SetAzureAutomationDscNode : AzureAutomationBaseCmdlet
    {
        /// <summary>
        /// True to overwrite the existing configuration; false otherwise.
        /// </summary>        
        private bool overwriteExistingNodeConfiguration;

        /// <summary> 
        /// Gets or sets the node id. 
        /// </summary> 
        [Parameter(ParameterSetName = AutomationCmdletParameterSets.ById, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The dsc node id.")]
        [Alias("NodeId")]
        [ValidateNotNullOrEmpty]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the nodeconfiguration name.
        /// </summary>
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The node configuration name that the node should now be mapped to.")]
        [ValidateNotNullOrEmpty]
        public string NodeConfigurationName { get; set; }

        /// <summary>
        /// Execute this cmdlet.
        /// </summary>
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public override void ExecuteCmdlet()
        {
            this.ConfirmAction(
                string.Format(CultureInfo.CurrentCulture, Resources.SetnodeconfigurationDescription),
                this.NodeConfigurationName,
                () =>
                {
                    var node = this.AutomationClient.SetDscNodeById(this.ResourceGroupName, this.AutomationAccountName, 
                        this.Id, this.NodeConfigurationName);
                    this.WriteObject(node);
                });

        }
    }
}
