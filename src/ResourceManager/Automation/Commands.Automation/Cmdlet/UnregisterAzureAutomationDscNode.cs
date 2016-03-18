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
    /// Removes the dsc node.
    /// </summary>
    [Cmdlet(VerbsLifecycle.Unregister, "AzureRmAutomationDscNode", SupportsShouldProcess=true)]
    [OutputType(typeof(DscNode))]
    public class UnregisterAzureAutomationDscNode : AzureAutomationBaseCmdlet
    {
        /// <summary> 
        /// Gets or sets the node id. 
        /// </summary> 
        [Parameter(ParameterSetName = AutomationCmdletParameterSets.ById, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The dsc node id.")]
        [Alias("NodeId")]
        [ValidateNotNullOrEmpty]
        public Guid Id { get; set; }

        /// <summary>
        /// Force parameter included for backward compatibility, deprecated, remove references to this parameter in scripts
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "Deprecated, this parameter will be removed in a future release")]
        public SwitchParameter Force { get; set; }

        /// <summary>
        /// Execute this cmdlet.
        /// </summary>
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public override void ExecuteCmdlet()
        {
            CheckForDeprecationWarning("Force", Force);
            this.ConfirmAction(
                string.Format(CultureInfo.CurrentCulture, Resources.RemoveDscNodeDescription, this.Id.ToString()),
                this.Id.ToString(),
                () =>
                {
                    AutomationClient.DeleteDscNode(this.ResourceGroupName, this.AutomationAccountName, this.Id);
                });
        }
    }
}
