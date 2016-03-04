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
using Microsoft.Azure.Management.Compute.Models;
using System.Management.Automation;
using System;
using AutoMapper;
using Microsoft.Azure.Commands.Compute.Models;

namespace Microsoft.Azure.Commands.Compute.Extension.AzureDiskEncryption
{
    [Cmdlet(
        VerbsCommon.Remove,
        ProfileNouns.AzureDiskEncryptionExtension, SupportsShouldProcess=true, ConfirmImpact=ConfirmImpact.High)]
    [OutputType(typeof(PSAzureOperationResponse))]
    public class RemoveAzureDiskEncryptionExtensionCommand : VirtualMachineExtensionBaseCmdlet
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
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The extension name. If this parameter is not specified, default values used are AzureDiskEncryption for windows VMs and AzureDiskEncryptionForLinux for Linux VMs")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            ExecuteClientAction(() =>
            {
                VirtualMachine virtualMachineResponse = (this.ComputeClient.ComputeManagementClient.VirtualMachines.Get(this.ResourceGroupName, this.VMName));

                string currentOSType = virtualMachineResponse.StorageProfile.OsDisk.OsType;
                if (string.Equals(currentOSType, "Windows", StringComparison.InvariantCultureIgnoreCase))
                {
                    this.Name = this.Name ?? AzureDiskEncryptionExtensionContext.ExtensionDefaultName;
                }
                else if (string.Equals(currentOSType, "Linux", StringComparison.InvariantCultureIgnoreCase))
                {
                    this.Name = this.Name ?? AzureDiskEncryptionExtensionContext.LinuxExtensionDefaultName;
                }

                if (this.ShouldProcess(string.Format(Properties.Resources.DiskEncryptionExtensionTarget, Name, VMName), 
                    Properties.Resources.RemoveAction))
                {
                    var op = this.VirtualMachineExtensionClient.DeleteWithHttpMessagesAsync(
                        this.ResourceGroupName,
                        this.VMName,
                        this.Name).GetAwaiter().GetResult();
                    var result = Mapper.Map<PSAzureOperationResponse>(op);
                    WriteObject(result);
                }
            });
        }
    }
}
