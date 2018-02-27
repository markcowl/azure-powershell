<#
Copyright (c) Microsoft Corporation. All rights reserved.
Licensed under the MIT License. See License.txt in the project root for license information.

Code generated by Microsoft (R) PSSwagger
Changes may cause incorrect behavior and will be lost if the code is regenerated.
#>

<#
.SYNOPSIS
    Returns a list of all Virtual Machine Extension Image.

.DESCRIPTION
    Returns a list of all Virtual Machine Extension Image.

.PARAMETER Type
    Type of extension.

.PARAMETER Version
    The version of the virtual machine image extension.

.PARAMETER LocationName
    Location of the resource.

.PARAMETER ResourceId
    The resource id.

.PARAMETER Publisher
    Name of the publisher.

.PARAMETER InputObject
    The input object of type Microsoft.AzureStack.Management.Compute.Admin.Models.VMExtension.

#>
function Get-AzsComputeVMExtension {
    [OutputType([Microsoft.AzureStack.Management.Compute.Admin.Models.VMExtension])]
    [CmdletBinding(DefaultParameterSetName = 'VMExtensions_List')]
    param(
        [Parameter(Mandatory = $true, ParameterSetName = 'VMExtensions_Get')]
        [System.String]
        $Type,

        [Parameter(Mandatory = $true, ParameterSetName = 'VMExtensions_Get')]
        [System.String]
        $Version,

        [Parameter(Mandatory = $false, ParameterSetName = 'VMExtensions_List')]
        [Parameter(Mandatory = $false, ParameterSetName = 'VMExtensions_Get')]
        [System.String]
        $Location,

        [Parameter(Mandatory = $true, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'ResourceId_VMExtensions_Get')]
        [System.String]
        $ResourceId,

        [Parameter(Mandatory = $true, ParameterSetName = 'VMExtensions_Get')]
        [System.String]
        $Publisher,

        [Parameter(Mandatory = $true, ValueFromPipeline = $true, ParameterSetName = 'InputObject_VMExtensions_Get')]
        [Microsoft.AzureStack.Management.Compute.Admin.Models.VMExtension]
        $InputObject
    )

    Begin {
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
            FullClientTypeName = 'Microsoft.AzureStack.Management.Compute.Admin.ComputeAdminClient'
        }

        $GlobalParameterHashtable = @{}
        $NewServiceClient_params['GlobalParameterHashtable'] = $GlobalParameterHashtable

        $GlobalParameterHashtable['SubscriptionId'] = $null
        if ($PSBoundParameters.ContainsKey('SubscriptionId')) {
            $GlobalParameterHashtable['SubscriptionId'] = $PSBoundParameters['SubscriptionId']
        }

        $ComputeAdminClient = New-ServiceClient @NewServiceClient_params

        if ('InputObject_VMExtensions_Get' -eq $PsCmdlet.ParameterSetName -or 'ResourceId_VMExtensions_Get' -eq $PsCmdlet.ParameterSetName) {
            $GetArmResourceIdParameterValue_params = @{
                IdTemplate = '/subscriptions/{subscriptionId}/providers/Microsoft.Compute.Admin/locations/{locationName}/artifactTypes/VMExtension/publishers/{publisher}/types/{type}/versions/{version}'
            }

            if ('ResourceId_VMExtensions_Get' -eq $PsCmdlet.ParameterSetName) {
                $GetArmResourceIdParameterValue_params['Id'] = $ResourceId
            } else {
                $GetArmResourceIdParameterValue_params['Id'] = $InputObject.Id
            }
            $ArmResourceIdParameterValues = Get-ArmResourceIdParameterValue @GetArmResourceIdParameterValue_params
            $Location = $ArmResourceIdParameterValues['locationName']

            $publisher = $ArmResourceIdParameterValues['publisher']

            $type = $ArmResourceIdParameterValues['type']

            $version = $ArmResourceIdParameterValues['version']
        } elseif ( -not $PSBoundParameters.Contains('Location')) {
            $Location = (Get-AzureRMLocation).Location
        }

        $filterInfos = @(
            @{
                'Type'     = 'powershellWildcard'
                'Value'    = $Version
                'Property' = 'Name'
            })
        $applicableFilters = Get-ApplicableFilters -Filters $filterInfos
        if ($applicableFilters | Where-Object { $_.Strict }) {
            Write-Verbose -Message 'Performing server-side call ''Get-AzsComputeVMExtension -'''
            $serverSideCall_params = @{

            }

            $serverSideResults = Get-AzsComputeVMExtension @serverSideCall_params
            foreach ($serverSideResult in $serverSideResults) {
                $valid = $true
                foreach ($applicableFilter in $applicableFilters) {
                    if (-not (Test-FilteredResult -Result $serverSideResult -Filter $applicableFilter.Filter)) {
                        $valid = $false
                        break
                    }
                }

                if ($valid) {
                    $serverSideResult
                }
            }
            return
        }
        if ('VMExtensions_Get' -eq $PsCmdlet.ParameterSetName -or 'InputObject_VMExtensions_Get' -eq $PsCmdlet.ParameterSetName -or 'ResourceId_VMExtensions_Get' -eq $PsCmdlet.ParameterSetName) {
            Write-Verbose -Message 'Performing operation GetWithHttpMessagesAsync on $ComputeAdminClient.'
            $TaskResult = $ComputeAdminClient.VMExtensions.GetWithHttpMessagesAsync($Location, $Publisher, $Type, $Version)
        } elseif ('VMExtensions_List' -eq $PsCmdlet.ParameterSetName) {
            Write-Verbose -Message 'Performing operation ListWithHttpMessagesAsync on $ComputeAdminClient.'
            $TaskResult = $ComputeAdminClient.VMExtensions.ListWithHttpMessagesAsync($Location)
        } else {
            Write-Verbose -Message 'Failed to map parameter set to operation method.'
            throw 'Module failed to find operation to execute.'
        }

        if ($TaskResult) {
            $GetTaskResult_params = @{
                TaskResult = $TaskResult
            }

            Get-TaskResult @GetTaskResult_params

        }
    }

    End {
        if ($tracerObject) {
            $global:DebugPreference = $oldDebugPreference
            Unregister-PSSwaggerClientTracing -TracerObject $tracerObject
        }
    }
}

