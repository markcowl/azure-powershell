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

using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using static Microsoft.Azure.Commands.Common.Profile;

namespace Microsoft.Azure.Commands.Common
{
    /// <summary>
    /// Selects the current Azure profile.
    /// </summary>
    [Cmdlet(VerbsCommon.Select, @"AzProfile", SupportsShouldProcess = true)]
    public class SelectAzProfile : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0 )]
        [Alias("ProfileName")]
        [ValidateSet("hybrid-2019", "latest", "sample")]
        public string Name { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                if(this.IsBound(nameof(Name)) && !String.IsNullOrEmpty(Name))
                {
                    ContextAdapter.Instance.SelectedProfile = Name;
                    var modules = GetModules(InvokeCommand).Where(m => GetProfiles(m).Contains(Name)).ToArray();
                    ReloadModules(InvokeCommand, modules);
                }
            }
            catch (Exception exception)
            {
                // Write exception out to error channel.
                WriteError(new ErrorRecord(exception, string.Empty, ErrorCategory.CloseError, null));
            }
        }
    }
}
