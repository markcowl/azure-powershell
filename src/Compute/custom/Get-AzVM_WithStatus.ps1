<#
.Synopsis
Retrieves information about the model view or the instance view of a virtual machine.
.Description
Retrieves information about the model view or the instance view of a virtual machine.
.Example
To view examples, please use the -Online parameter with Get-Help or navigate to: https://docs.microsoft.com/en-us/powershell/module/az.compute/get-azvm
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.IComputeIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20190301.IVirtualMachine
.Notes
COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IComputeIdentity>: Identity Parameter
  [AvailabilitySetName <String>]: The name of the availability set.
  [CommandId <String>]: The command id.
  [DiskName <String>]: The name of the managed disk that is being created. The name can't be changed after the disk is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The maximum name length is 80 characters.
  [GalleryApplicationName <String>]: The name of the gallery Application Definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters.
  [GalleryApplicationVersionName <String>]: The name of the gallery Application Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: <MajorVersion>.<MinorVersion>.<Patch>
  [GalleryImageDefinitionName <String>]: The name of the gallery Image Definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters.
  [GalleryImageVersionName <String>]: The name of the gallery Image Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: <MajorVersion>.<MinorVersion>.<Patch>
  [GalleryName <String>]: The name of the Shared Image Gallery. The allowed characters are alphabets and numbers with dots and periods allowed in the middle. The maximum length is 80 characters.
  [Id <String>]: Resource identity path
  [ImageName <String>]: The name of the image.
  [InstanceId <String>]: The instance ID of the virtual machine.
  [Location <String>]: The name of a supported Azure region.
  [Offer <String>]: A valid image publisher offer.
  [ProximityPlacementGroupName <String>]: The name of the proximity placement group.
  [PublisherName <String>]: 
  [ResourceGroupName <String>]: The name of the resource group.
  [Sku <String>]: A valid image SKU.
  [SnapshotName <String>]: The name of the snapshot that is being created. The name can't be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The max name length is 80 characters.
  [SubscriptionId <String>]: Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
  [Type <String>]: 
  [VMExtensionName <String>]: The name of the virtual machine extension.
  [VMName <String>]: The name of the virtual machine.
  [VMScaleSetName <String>]: The name of the VM scale set.
  [Version <String>]: 
  [VirtualMachineScaleSetName <String>]: The name of the VM scale set.
  [VmssExtensionName <String>]: The name of the VM scale set extension.
.Link
https://docs.microsoft.com/en-us/powershell/module/az.compute/get-azvm
#>
function Get-AzVM {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20190301.IVirtualMachine])]
[CmdletBinding(DefaultParameterSetName='List5', PositionalBinding=$false)]
[Microsoft.Azure.PowerShell.Cmdlets.Compute.Profile('latest-2019-04-30')]
param(

    [Parameter(Mandatory)]
    [System.Management.Automation.SwitchParameter]
    # Include VM running status details
    ${Status},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Path')]
    [System.String]
    # The name of the virtual machine.
    ${Name},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Path')]
    [System.String]
    # The name of the resource group.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.IComputeIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Path')]
    [System.String]
    # The location for which virtual machines under the subscription are queried.
    ${Location},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.InstanceViewTypes])]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Query')]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.InstanceViewTypes]
    # The expand expression to apply on the operation.
    ${Expand},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $PSBoundParameters.Remove("Status")
        $getCommand = $ExecutionContext.InvokeCommand.GetCommand(('Az.Compute\Get-AzVM'), [System.Management.Automation.CommandTypes]::Cmdlet)
        $viewCommand = $ExecutionContext.InvokeCommand.GetCommand(($'Az.Compute.Internal\Invoke-AzViewVMInstance']), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptEx = {& $getCommand @PSBoundParameters | %{$_.InstanceView = (& $viewCommand -InputObject $_) ; $_}}
        $steppablePipeline = $scriptEx.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    $steppablePipeline.Process($_)
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
