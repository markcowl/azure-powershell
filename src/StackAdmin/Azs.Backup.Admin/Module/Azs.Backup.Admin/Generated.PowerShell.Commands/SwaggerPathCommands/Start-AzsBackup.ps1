<#
Copyright (c) Microsoft and contributors.  All rights reserved.

Licensed under the Apache License, Version 2.0 (the ""License"");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
  http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

See the License for the specific language governing permissions and
limitations under the License.

Code generated by Microsoft (R) PSSwagger 0.3.0
Changes may cause incorrect behavior and will be lost if the code is regenerated.
#>

<#
.SYNOPSIS
    Back up a specific location.

.DESCRIPTION
    Back up a specific location.

.PARAMETER ResourceGroup
    Name of the resource group.

.PARAMETER Location
    Name of the backup location.

#>
function Start-AzsBackup
{
    [OutputType([Microsoft.AzureStack.Management.Backup.Admin.Models.LongRunningOperationStatus])]
    [CmdletBinding(DefaultParameterSetName='CreateBackup')]
    param(
        [Parameter(Mandatory = $false, ParameterSetName = 'CreateBackup')]
        [System.String]
        $ResourceGroup,

        [Parameter(Mandatory = $false, ParameterSetName = 'CreateBackup')]
        [System.String]
        $Location,

        [Parameter(Mandatory = $true, ValueFromPipeline = $true, ParameterSetName = 'CreateBackup_FromInput')]
        [Microsoft.AzureStack.Management.Backup.Admin.Models.BackupLocation]
        $InputObject,

        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'CreateBackup_FromResourceId')]
        [System.String]
        $ResourceId,

        [Parameter(Mandatory = $false)]
        [switch]
        $AsJob
    )

    Begin
    {
	    Initialize-PSSwaggerDependencies -Azure
        $tracerObject = $null
        if (('continue' -eq $DebugPreference) -or ('inquire' -eq $DebugPreference)) {
            $oldDebugPreference = $global:DebugPreference
			$global:DebugPreference = "continue"
            $tracerObject = New-PSSwaggerClientTracing
            Register-PSSwaggerClientTracing -TracerObject $tracerObject
        }
	}

    Process {

    $ErrorActionPreference = 'Stop'

    $NewServiceClient_params = @{
        FullClientTypeName = 'Microsoft.AzureStack.Management.Backup.Admin.BackupAdminClient'
    }

    $GlobalParameterHashtable = @{}
    $NewServiceClient_params['GlobalParameterHashtable'] = $GlobalParameterHashtable

    $GlobalParameterHashtable['SubscriptionId'] = $null
    if($PSBoundParameters.ContainsKey('SubscriptionId')) {
        $GlobalParameterHashtable['SubscriptionId'] = $PSBoundParameters['SubscriptionId']
    }

    $BackupAdminClient = New-ServiceClient @NewServiceClient_params


    if( ('CreateBackup_FromInput' -eq $PsCmdlet.ParameterSetName) -or ('CreateBackup_FromResourceId' -eq $PsCmdlet.ParameterSetName) ) {
        $GetArmResourceIdParameterValue_params = @{
            IdTemplate = '/subscriptions/{subscriptionId}/resourcegroups/{resourceGroup}/providers/Microsoft.Backup.Admin/backupLocations/{location}/'
        }

        if('CreateBackup_FromResourceId' -eq $PsCmdlet.ParameterSetName) {
            $GetArmResourceIdParameterValue_params['Id'] = $ResourceId
        }
        else {
            $GetArmResourceIdParameterValue_params['Id'] = $InputObject.Id
        }
        $ArmResourceIdParameterValues = Get-ArmResourceIdParameterValue @GetArmResourceIdParameterValue_params

        $ResourceGroup = $ArmResourceIdParameterValues['resourceGroup']
        $Location = $ArmResourceIdParameterValues['location']
    } else {
        if (-not $PSBoundParameters.ContainsKey('Location')) {
            $Location = (Get-AzureRMLocation).Location
        }
        if (-not $PSBoundParameters.ContainsKey('ResourceGroup'))
        {
            $ResourceGroup = "System.$($Location)"
        }
    }

    if ( ('CreateBackup' -eq $PsCmdlet.ParameterSetName) -or ('CreateBackup_FromInput' -eq $PsCmdlet.ParameterSetName) -or ('CreateBackup_FromResourceId' -eq $PsCmdlet.ParameterSetName) ){
        Write-Verbose -Message 'Performing operation CreateBackupWithHttpMessagesAsync on $BackupAdminClient.'
        $TaskResult = $BackupAdminClient.BackupLocations.CreateBackupWithHttpMessagesAsync($ResourceGroup, $Location)
    } else {
        Write-Verbose -Message 'Failed to map parameter set to operation method.'
        throw 'Module failed to find operation to execute.'
    }

    Write-Verbose -Message "Waiting for the operation to complete."

    $PSSwaggerJobScriptBlock = {
        [CmdletBinding()]
        param(
            [Parameter(Mandatory = $true)]
            [System.Threading.Tasks.Task]
            $TaskResult,

            [Parameter(Mandatory = $true)]
			[string]
			$TaskHelperFilePath
        )
        if ($TaskResult) {
            . $TaskHelperFilePath
            $GetTaskResult_params = @{
                TaskResult = $TaskResult
            }

            Get-TaskResult @GetTaskResult_params

        }
    }

    $PSCommonParameters = Get-PSCommonParameter -CallerPSBoundParameters $PSBoundParameters
    $TaskHelperFilePath = Join-Path -Path $ExecutionContext.SessionState.Module.ModuleBase -ChildPath 'Get-TaskResult.ps1'
    if($AsJob)
    {
        $ScriptBlockParameters = New-Object -TypeName 'System.Collections.Generic.Dictionary[string,object]'
        $ScriptBlockParameters['TaskResult'] = $TaskResult
        $ScriptBlockParameters['AsJob'] = $AsJob
        $ScriptBlockParameters['TaskHelperFilePath'] = $TaskHelperFilePath
        $PSCommonParameters.GetEnumerator() | ForEach-Object { $ScriptBlockParameters[$_.Name] = $_.Value }

        Start-PSSwaggerJobHelper -ScriptBlock $PSSwaggerJobScriptBlock `
                                     -CallerPSBoundParameters $ScriptBlockParameters `
                                     -CallerPSCmdlet $PSCmdlet `
                                     @PSCommonParameters
    }
    else
    {
        Invoke-Command -ScriptBlock $PSSwaggerJobScriptBlock `
                       -ArgumentList $TaskResult,$TaskHelperFilePath `
                       @PSCommonParameters
    }
    }

    End {
        if ($tracerObject) {
            $global:DebugPreference = $oldDebugPreference
            Unregister-PSSwaggerClientTracing -TracerObject $tracerObject
        }
    }
}

