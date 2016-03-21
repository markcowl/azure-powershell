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

using Microsoft.Azure.Commands.Compute.Common;
using Microsoft.Azure.Management.Compute;
using System.Management.Automation;
using AutoMapper;
using Microsoft.Azure.Commands.Compute.Models;
using Microsoft.WindowsAzure.Commands.Common;

namespace Microsoft.Azure.Commands.Compute
{
    [Cmdlet(
        VerbsCommon.Remove,
        ProfileNouns.VirtualMachineCustomScriptExtension, SupportsShouldProcess = true)]
    [OutputType(typeof(PSAzureOperationResponse))]
    public class RemoveAzureVMCustomScriptExtensionCommand : VirtualMachineExtensionBaseCmdlet
    {
        [Parameter(
           Mandatory = true,
           Position = 0,
           ValueFromPipelineByPropertyName = true,
           HelpMessage = "The resource group name.")]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Alias("ResourceName")]
        [Parameter(
            Mandatory = true,
            Position = 1,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The virtual machine name.")]
        [ValidateNotNullOrEmpty]
        public string VMName { get; set; }

        [Alias("ExtensionName")]
        [Parameter(
            Mandatory = true,
            Position = 2,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The extension name.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        /// <summary>
        /// Force parameter included for backward compatibility, deprecated, remove references to this parameter in scripts
        /// </summary>
        [Deprecated, Parameter(Mandatory = false, HelpMessage = "Deprecated, this parameter will be removed in a future release")]
        public SwitchParameter Force { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            ExecuteClientAction(() =>
            {
                ConfirmAction(Properties.Resources.VirtualMachineExtensionRemovalAction, 
                    string.Format(Properties.Resources.VirtualMachineExtensionTarget, Name, VMName),
                    () =>
                    {
                        var op = this.VirtualMachineExtensionClient.DeleteWithHttpMessagesAsync(
                            this.ResourceGroupName,
                            this.VMName,
                            this.Name).GetAwaiter().GetResult();
                        var result = Mapper.Map<PSAzureOperationResponse>(op);
                        WriteObject(result);
                    });
            });
        }

    }
}
