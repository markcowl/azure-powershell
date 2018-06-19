function Import-RegistryImage {
[CmdletBinding(DefaultParameterSetName='ImageRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage')]
param(
    [Parameter(ParameterSetName='ImageRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ImageResourceGroupNameRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ImageSubscriptionIdRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ImageSubscriptionIdResourceGroupNameRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='ImageRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ImageResourceGroupNameRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ImageSubscriptionIdRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ImageSubscriptionIdResourceGroupNameRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='ImageRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [Parameter(ParameterSetName='ImageResourceGroupNameRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [Parameter(ParameterSetName='ImageSubscriptionIdRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [Parameter(ParameterSetName='ImageSubscriptionIdResourceGroupNameRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', Mandatory=$true, HelpMessage='HELP MESSAGE MISSING')]
    [Sample.API.Models.IImportImageParameters]
    ${Parameters},

    [Parameter(ParameterSetName='ImageRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='ImageResourceGroupNameRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='ImageSubscriptionIdRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='ImageSubscriptionIdResourceGroupNameRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [string]
    ${RegistryName},

    [Parameter(ParameterSetName='ImageResourceGroupNameRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='ImageSubscriptionIdResourceGroupNameRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='ImageSubscriptionIdRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='ImageSubscriptionIdResourceGroupNameRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'ImageSubscriptionIdRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Import-RegistryImage_ImageSubscriptionIdRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ImageResourceGroupNameRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Import-RegistryImage_ImageResourceGroupNameRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ImageRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Import-RegistryImage_ImageRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ImageSubscriptionIdResourceGroupNameRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Import-RegistryImage_ImageSubscriptionIdResourceGroupNameRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  default {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Import-RegistryImage_ImageRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

}
}

process
{
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end
{
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
<#

.ForwardHelpTargetName ContainerRegistryManagement.private\Import-RegistryImage_ImageRegistryNameModeSourceTargetTagsUntaggedTargetRepositoriesRegistriesImportImage
.ForwardHelpCategory Cmdlet

#>

}

