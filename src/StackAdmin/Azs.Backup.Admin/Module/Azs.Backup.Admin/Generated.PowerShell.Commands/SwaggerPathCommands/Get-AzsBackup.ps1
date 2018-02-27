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
    Returns a backup from a location based on name.

.DESCRIPTION
    Returns a backup from a location based on name.

.PARAMETER Name
    Name of the backup.

.PARAMETER Location
    Name of the backup location.

.PARAMETER ResourceId
    The resource id.

.PARAMETER ResourceGroup
    Name of the resource group.

.PARAMETER InputObject
    The input object of type Microsoft.AzureStack.Management.Backup.Admin.Models.Backup.

#>
function Get-AzsBackup
{
    [OutputType([Microsoft.AzureStack.Management.Backup.Admin.Models.Backup])]
    [CmdletBinding(DefaultParameterSetName='Backups_List')]
    param(
        [Parameter(Mandatory = $true, ParameterSetName = 'Backups_Get')]
        [Alias('Backup')]
        [System.String]
        $Name,

        [Parameter(Mandatory = $true, ParameterSetName = 'Backups_List')]
        [Parameter(Mandatory = $true, ParameterSetName = 'Backups_Get')]
        [System.String]
        $Location,

        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'ResourceId_Backups_Get')]
        [System.String]
        $ResourceId,

        [Parameter(Mandatory = $false, ParameterSetName = 'Backups_List')]
        [Parameter(Mandatory = $false, ParameterSetName = 'Backups_Get')]
        [System.String]
        $ResourceGroup,

        [Parameter(Mandatory = $true, ValueFromPipeline = $true, ParameterSetName = 'InputObject_Backups_Get')]
        [Microsoft.AzureStack.Management.Backup.Admin.Models.Backup]
        $InputObject,

        [Parameter(Mandatory = $true, ValueFromPipeline = $true, ParameterSetName = 'ParentObject_Backups_Get')]
        [Microsoft.AzureStack.Management.Backup.Admin.Models.BackupLocation]
        $ParentObject,

        [Parameter(Mandatory = $false, ParameterSetName = 'ParentObject_Backups_Get')]
        [Parameter(Mandatory = $false, ParameterSetName = 'Backups_List')]
        [int]
        $Top = -1,

        [Parameter(Mandatory = $false, ParameterSetName = 'ParentObject_Backups_Get')]
        [Parameter(Mandatory = $false, ParameterSetName = 'Backups_List')]
        [int]
        $Skip = -1
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

    $Backup = $Name


    if('InputObject_Backups_Get' -eq $PsCmdlet.ParameterSetName -or 'ResourceId_Backups_Get' -eq $PsCmdlet.ParameterSetName) {
        $GetArmResourceIdParameterValue_params = @{
            IdTemplate = '/subscriptions/{subscriptionId}/resourcegroups/{resourceGroup}/providers/Microsoft.Backup.Admin/backupLocations/{location}/backups/{backup}'
        }

        if('ResourceId_Backups_Get' -eq $PsCmdlet.ParameterSetName) {
            $GetArmResourceIdParameterValue_params['Id'] = $ResourceId
        }
        else {
            $GetArmResourceIdParameterValue_params['Id'] = $InputObject.Id
        }
        $ArmResourceIdParameterValues = Get-ArmResourceIdParameterValue @GetArmResourceIdParameterValue_params

        $resourceGroup = $ArmResourceIdParameterValues['resourceGroup']
        $Location = $ArmResourceIdParameterValues['location']
        $backup = $ArmResourceIdParameterValues['backup']
    } elseif (-not $PSBoundParameters.ContainsKey('ResourceGroup'))
    {
        $ResourceGroup = "System.$((Get-AzureRMLocation).Location)"
    }

    if ('ParentObject_Backups_Get' -eq $PsCmdlet.ParameterSetName) {

        $GetArmResourceIdParameterValue_params = @{
            IdTemplate = '/subscriptions/{subscriptionId}/resourcegroups/{resourceGroup}/providers/Microsoft.Backup.Admin/backupLocations/{location}'
        }

        $GetArmResourceIdParameterValue_params['Id'] = $ParentObject.Id

        $ArmResourceIdParameterValues = Get-ArmResourceIdParameterValue @GetArmResourceIdParameterValue_params
        $resourceGroup = $ArmResourceIdParameterValues['resourceGroup']
        $Location = $ArmResourceIdParameterValues['location']
    }

    if ('Backups_List' -eq $PsCmdlet.ParameterSetName -or 'ParentObject_Backups_Get' -eq $PsCmdlet.ParameterSetName) {
        Write-Verbose -Message 'Performing operation ListWithHttpMessagesAsync on $BackupAdminClient.'
        $TaskResult = $BackupAdminClient.Backups.ListWithHttpMessagesAsync($ResourceGroup, $Location)
    } elseif ('Backups_Get' -eq $PsCmdlet.ParameterSetName -or 'InputObject_Backups_Get' -eq $PsCmdlet.ParameterSetName -or 'ResourceId_Backups_Get' -eq $PsCmdlet.ParameterSetName) {
        Write-Verbose -Message 'Performing operation GetWithHttpMessagesAsync on $BackupAdminClient.'
        $TaskResult = $BackupAdminClient.Backups.GetWithHttpMessagesAsync($ResourceGroup, $Location, $Backup)
    } else {
        Write-Verbose -Message 'Failed to map parameter set to operation method.'
        throw 'Module failed to find operation to execute.'
    }

    if ($TaskResult) {
        $GetTaskResult_params = @{
            TaskResult = $TaskResult
        }

        $TopInfo = @{
            'Count' = 0
            'Max' = $Top
        }
        $GetTaskResult_params['TopInfo'] = $TopInfo
        $SkipInfo = @{
            'Count' = 0
            'Max' = $Skip
        }
        $GetTaskResult_params['SkipInfo'] = $SkipInfo
        $PageResult = @{
            'Result' = $null
        }
        $GetTaskResult_params['PageResult'] = $PageResult
        $GetTaskResult_params['PageType'] = 'Microsoft.Rest.Azure.IPage[Microsoft.AzureStack.Management.Backup.Admin.Models.Backup]' -as [Type]

        Get-TaskResult @GetTaskResult_params

        Write-Verbose -Message 'Flattening paged results.'
        while ($PageResult -and $PageResult.Result -and (Get-Member -InputObject $PageResult.Result -Name 'nextLink') -and $PageResult.Result.'nextLink' -and (($TopInfo -eq $null) -or ($TopInfo.Max -eq -1) -or ($TopInfo.Count -lt $TopInfo.Max))) {
            $PageResult.Result = $null
            Write-Debug -Message "Retrieving next page: $($PageResult.Result.'nextLink')"
            $TaskResult = $BackupAdminClient.Backups.ListNextWithHttpMessagesAsync($PageResult.Result.'nextLink')
            $GetTaskResult_params['TaskResult'] = $TaskResult
            $GetTaskResult_params['PageResult'] = $PageResult
            Get-TaskResult @GetTaskResult_params
        }
    }
    }

    End {
        if ($tracerObject) {
            $global:DebugPreference = $oldDebugPreference
            Unregister-PSSwaggerClientTracing -TracerObject $tracerObject
        }
    }
}

