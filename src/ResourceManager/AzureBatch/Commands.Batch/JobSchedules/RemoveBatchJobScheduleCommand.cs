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

using System.Management.Automation;
using Microsoft.Azure.Commands.Batch.Properties;
using Constants = Microsoft.Azure.Commands.Batch.Utils.Constants;

namespace Microsoft.Azure.Commands.Batch
{
    [Cmdlet(VerbsCommon.Remove, Constants.AzureBatchJobSchedule, SupportsShouldProcess = true)]
    public class RemoveBatchJobScheduleCommand : BatchObjectModelCmdletBase
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipelineByPropertyName = true, 
            HelpMessage = "The id of the job schedule to delete.")]
        [ValidateNotNullOrEmpty]
        public string Id { get; set; }

        /// <summary>
        /// Force parameter included for backward compatibility, deprecated, remove references to this parameter in scripts
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "Deprecated, this parameter will be removed in a future release")]
        public SwitchParameter Force { get; set; }

        public override void ExecuteCmdlet()
        {
            CheckForDeprecationWarning("Force", Force);
            ConfirmAction(
                Resources.RemoveJobSchedule,
                this.Id,
                () => BatchClient.DeleteJobSchedule(this.BatchContext, this.Id, this.AdditionalBehaviors));
        }
    }
}
