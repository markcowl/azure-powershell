function Get-RegistryCredential {
[CmdletBinding(DefaultParameterSetName='CredentialsRegistryNameRegistriesListCredentials')]
param(
    [Parameter(ParameterSetName='CredentialsRegistryNameRegistriesListCredentials', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='CredentialsResourceGroupNameRegistryNameRegistriesListCredentials', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='CredentialsSubscriptionIdRegistryNameRegistriesListCredentials', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='CredentialsSubscriptionIdResourceGroupNameRegistryNameRegistriesListCredentials', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='CredentialsRegistryNameRegistriesListCredentials', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='CredentialsResourceGroupNameRegistryNameRegistriesListCredentials', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='CredentialsSubscriptionIdRegistryNameRegistriesListCredentials', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='CredentialsSubscriptionIdResourceGroupNameRegistryNameRegistriesListCredentials', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='CredentialsRegistryNameRegistriesListCredentials', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='CredentialsResourceGroupNameRegistryNameRegistriesListCredentials', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='CredentialsSubscriptionIdRegistryNameRegistriesListCredentials', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='CredentialsSubscriptionIdResourceGroupNameRegistryNameRegistriesListCredentials', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [string]
    ${RegistryName},

    [Parameter(ParameterSetName='CredentialsResourceGroupNameRegistryNameRegistriesListCredentials', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='CredentialsSubscriptionIdResourceGroupNameRegistryNameRegistriesListCredentials', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='CredentialsSubscriptionIdRegistryNameRegistriesListCredentials', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='CredentialsSubscriptionIdResourceGroupNameRegistryNameRegistriesListCredentials', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'CredentialsResourceGroupNameRegistryNameRegistriesListCredentials' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Get-RegistryCredential_CredentialsResourceGroupNameRegistryNameRegistriesListCredentials', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'CredentialsSubscriptionIdResourceGroupNameRegistryNameRegistriesListCredentials' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Get-RegistryCredential_CredentialsSubscriptionIdResourceGroupNameRegistryNameRegistriesListCredentials', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'CredentialsRegistryNameRegistriesListCredentials' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Get-RegistryCredential_CredentialsRegistryNameRegistriesListCredentials', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'CredentialsSubscriptionIdRegistryNameRegistriesListCredentials' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Get-RegistryCredential_CredentialsSubscriptionIdRegistryNameRegistriesListCredentials', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Get-RegistryCredential_CredentialsRegistryNameRegistriesListCredentials', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName ContainerRegistryManagement.private\Get-RegistryCredential_CredentialsRegistryNameRegistriesListCredentials
.ForwardHelpCategory Cmdlet

#>

}

