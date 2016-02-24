﻿//  
// Copyright (c) Microsoft.  All rights reserved.
// 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
// 
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

namespace Microsoft.Azure.Commands.ApiManagement.ServiceManagement.Commands
{
    using System;
    using System.Globalization;
    using System.Management.Automation;
    using Microsoft.Azure.Commands.ApiManagement.ServiceManagement.Models;
    using Microsoft.Azure.Commands.ApiManagement.ServiceManagement.Properties;

    [Cmdlet(VerbsCommon.Remove, "AzureRmApiManagementProduct", SupportsShouldProcess=true, ConfirmImpact=ConfirmImpact.High)]
    [OutputType(typeof(bool))]
    public class RemoveAzureApiManagementProduct : AzureApiManagementCmdletBase
    {
        [Parameter(
            ValueFromPipelineByPropertyName = true, 
            Mandatory = true, 
            HelpMessage = "Instance of PsApiManagementContext. This parameter is required.")]
        [ValidateNotNullOrEmpty]
        public PsApiManagementContext Context { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true, 
            Mandatory = true, 
            HelpMessage = "Identifier of existing Product. This parameter is required.")]
        [ValidateNotNullOrEmpty]
        public String ProductId { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true, 
            Mandatory = false, 
            HelpMessage = "Whether to delete subscriptions to the product or not. If not set and subscriptions exists exception will be thrown. This parameter is optional.")]
        public SwitchParameter DeleteSubscriptions { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true,
            Mandatory = false, 
            HelpMessage = "Forces delete operation (prevents confirmation dialog). This parameter is optional.")]
        public SwitchParameter Force { get; set; }

        [Parameter(
            ValueFromPipelineByPropertyName = true, 
            Mandatory = false, 
            HelpMessage = "If specified will write true in case operation succeeds. This parameter is optional.")]
        public SwitchParameter PassThru { get; set; }

        public override void ExecuteApiManagementCmdlet()
        {
            var actionDescription = string.Format(CultureInfo.CurrentCulture, Resources.ProductRemoveDescription, ProductId);
            var actionWarning = string.Format(CultureInfo.CurrentCulture, Resources.ProductRemoveWarning, ProductId);

            // Do nothing if force is not specified and user cancelled the operation
            if (!Force.IsPresent &&
                !ShouldProcess(
                    actionDescription,
                    actionWarning,
                    Resources.ShouldProcessCaption))
            {
                return;
            }

            Client.ProductRemove(Context, ProductId, DeleteSubscriptions);

            if (PassThru.IsPresent)
            {
                WriteObject(true);
            }
        }
    }
}
