function New-Registry {
[CmdletBinding(DefaultParameterSetName='RegistryNameLocationTagsPropertiesSkuRegistriesCreate')]
param(
    [Parameter(ParameterSetName='RegistryNameLocationTagsPropertiesSkuRegistriesCreate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameLocationTagsPropertiesSkuRegistriesCreate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameLocationTagsPropertiesSkuRegistriesCreate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameLocationTagsPropertiesSkuRegistriesCreate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='RegistryNameLocationTagsPropertiesSkuRegistriesCreate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameLocationTagsPropertiesSkuRegistriesCreate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameLocationTagsPropertiesSkuRegistriesCreate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameLocationTagsPropertiesSkuRegistriesCreate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='RegistryNameLocationTagsPropertiesSkuRegistriesCreate', Mandatory=$true, HelpMessage='An object that represents a container registry.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameLocationTagsPropertiesSkuRegistriesCreate', Mandatory=$true, HelpMessage='An object that represents a container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameLocationTagsPropertiesSkuRegistriesCreate', Mandatory=$true, HelpMessage='An object that represents a container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameLocationTagsPropertiesSkuRegistriesCreate', Mandatory=$true, HelpMessage='An object that represents a container registry.')]
    [Sample.API.Models.IRegistry]
    ${Registry},

    [Parameter(ParameterSetName='RegistryNameLocationTagsPropertiesSkuRegistriesCreate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameLocationTagsPropertiesSkuRegistriesCreate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameLocationTagsPropertiesSkuRegistriesCreate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameLocationTagsPropertiesSkuRegistriesCreate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [string]
    ${RegistryName},

    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameLocationTagsPropertiesSkuRegistriesCreate', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameLocationTagsPropertiesSkuRegistriesCreate', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='SubscriptionIdRegistryNameLocationTagsPropertiesSkuRegistriesCreate', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameLocationTagsPropertiesSkuRegistriesCreate', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'RegistryNameLocationTagsPropertiesSkuRegistriesCreate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-Registry_RegistryNameLocationTagsPropertiesSkuRegistriesCreate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SubscriptionIdRegistryNameLocationTagsPropertiesSkuRegistriesCreate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-Registry_SubscriptionIdRegistryNameLocationTagsPropertiesSkuRegistriesCreate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SubscriptionIdResourceGroupNameRegistryNameLocationTagsPropertiesSkuRegistriesCreate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-Registry_SubscriptionIdResourceGroupNameRegistryNameLocationTagsPropertiesSkuRegistriesCreate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ResourceGroupNameRegistryNameLocationTagsPropertiesSkuRegistriesCreate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-Registry_ResourceGroupNameRegistryNameLocationTagsPropertiesSkuRegistriesCreate', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-Registry_RegistryNameLocationTagsPropertiesSkuRegistriesCreate', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName ContainerRegistryManagement.private\New-Registry_RegistryNameLocationTagsPropertiesSkuRegistriesCreate
.ForwardHelpCategory Cmdlet

#>

}

