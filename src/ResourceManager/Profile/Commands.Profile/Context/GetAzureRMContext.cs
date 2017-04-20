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

using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common.Authentication.Models;
using Microsoft.Azure.Commands.Profile.Models;
using Microsoft.Azure.Commands.ResourceManager.Common;
using Microsoft.WindowsAzure.Commands.Common;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Profile
{
    /// <summary>
    /// Cmdlet to get current context. 
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "AzureRmContext")]
    [OutputType(typeof(PSAzureContext))]
    public class GetAzureRMContextCommand : AzureRMCmdlet
    {
        public override void ExecuteCmdlet()
        {
            WriteObject(new PSAzureContext(AzureRmProfileProvider.Instance.GetProfile<AzureRmProfile>().DefaultContext));
        }
    }
}
