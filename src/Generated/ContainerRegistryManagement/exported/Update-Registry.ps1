function Update-Registry {
[CmdletBinding(DefaultParameterSetName='RegistryNamePropertiesSkuTagsRegistriesUpdate')]
param(
    [Parameter(ParameterSetName='RegistryNamePropertiesSkuTagsRegistriesUpdate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNamePropertiesSkuTagsRegistriesUpdate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNamePropertiesSkuTagsRegistriesUpdate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNamePropertiesSkuTagsRegistriesUpdate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='RegistryNamePropertiesSkuTagsRegistriesUpdate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNamePropertiesSkuTagsRegistriesUpdate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNamePropertiesSkuTagsRegistriesUpdate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNamePropertiesSkuTagsRegistriesUpdate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='RegistryNamePropertiesSkuTagsRegistriesUpdate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNamePropertiesSkuTagsRegistriesUpdate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNamePropertiesSkuTagsRegistriesUpdate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNamePropertiesSkuTagsRegistriesUpdate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [string]
    ${RegistryName},

    [Parameter(ParameterSetName='RegistryNamePropertiesSkuTagsRegistriesUpdate', Mandatory=$true, HelpMessage='The parameters for updating a container registry.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNamePropertiesSkuTagsRegistriesUpdate', Mandatory=$true, HelpMessage='The parameters for updating a container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNamePropertiesSkuTagsRegistriesUpdate', Mandatory=$true, HelpMessage='The parameters for updating a container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNamePropertiesSkuTagsRegistriesUpdate', Mandatory=$true, HelpMessage='The parameters for updating a container registry.')]
    [Sample.API.Models.IRegistryUpdateParameters]
    ${RegistryUpdateParameters},

    [Parameter(ParameterSetName='ResourceGroupNameRegistryNamePropertiesSkuTagsRegistriesUpdate', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNamePropertiesSkuTagsRegistriesUpdate', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='SubscriptionIdRegistryNamePropertiesSkuTagsRegistriesUpdate', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNamePropertiesSkuTagsRegistriesUpdate', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'ResourceGroupNameRegistryNamePropertiesSkuTagsRegistriesUpdate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Update-Registry_ResourceGroupNameRegistryNamePropertiesSkuTagsRegistriesUpdate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'RegistryNamePropertiesSkuTagsRegistriesUpdate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Update-Registry_RegistryNamePropertiesSkuTagsRegistriesUpdate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SubscriptionIdRegistryNamePropertiesSkuTagsRegistriesUpdate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Update-Registry_SubscriptionIdRegistryNamePropertiesSkuTagsRegistriesUpdate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SubscriptionIdResourceGroupNameRegistryNamePropertiesSkuTagsRegistriesUpdate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Update-Registry_SubscriptionIdResourceGroupNameRegistryNamePropertiesSkuTagsRegistriesUpdate', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Update-Registry_RegistryNamePropertiesSkuTagsRegistriesUpdate', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName ContainerRegistryManagement.private\Update-Registry_RegistryNamePropertiesSkuTagsRegistriesUpdate
.ForwardHelpCategory Cmdlet

#>

}

