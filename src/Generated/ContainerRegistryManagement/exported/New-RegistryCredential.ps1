function New-RegistryCredential {
[CmdletBinding(DefaultParameterSetName='CredentialRegistryNameNameRegistriesRegenerateCredential')]
param(
    [Parameter(ParameterSetName='CredentialRegistryNameNameRegistriesRegenerateCredential', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='CredentialResourceGroupNameRegistryNameNameRegistriesRegenerateCredential', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='CredentialSubscriptionIdRegistryNameNameRegistriesRegenerateCredential', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='CredentialSubscriptionIdResourceGroupNameRegistryNameNameRegistriesRegenerateCredential', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='CredentialRegistryNameNameRegistriesRegenerateCredential', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='CredentialResourceGroupNameRegistryNameNameRegistriesRegenerateCredential', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='CredentialSubscriptionIdRegistryNameNameRegistriesRegenerateCredential', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='CredentialSubscriptionIdResourceGroupNameRegistryNameNameRegistriesRegenerateCredential', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='CredentialRegistryNameNameRegistriesRegenerateCredential', Mandatory=$true, HelpMessage='The parameters used to regenerate the login credential.')]
    [Parameter(ParameterSetName='CredentialResourceGroupNameRegistryNameNameRegistriesRegenerateCredential', Mandatory=$true, HelpMessage='The parameters used to regenerate the login credential.')]
    [Parameter(ParameterSetName='CredentialSubscriptionIdRegistryNameNameRegistriesRegenerateCredential', Mandatory=$true, HelpMessage='The parameters used to regenerate the login credential.')]
    [Parameter(ParameterSetName='CredentialSubscriptionIdResourceGroupNameRegistryNameNameRegistriesRegenerateCredential', Mandatory=$true, HelpMessage='The parameters used to regenerate the login credential.')]
    [Sample.API.Models.IRegenerateCredentialParameters]
    ${RegenerateCredentialParameters},

    [Parameter(ParameterSetName='CredentialRegistryNameNameRegistriesRegenerateCredential', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='CredentialResourceGroupNameRegistryNameNameRegistriesRegenerateCredential', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='CredentialSubscriptionIdRegistryNameNameRegistriesRegenerateCredential', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='CredentialSubscriptionIdResourceGroupNameRegistryNameNameRegistriesRegenerateCredential', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [string]
    ${RegistryName},

    [Parameter(ParameterSetName='CredentialResourceGroupNameRegistryNameNameRegistriesRegenerateCredential', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='CredentialSubscriptionIdResourceGroupNameRegistryNameNameRegistriesRegenerateCredential', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='CredentialSubscriptionIdRegistryNameNameRegistriesRegenerateCredential', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='CredentialSubscriptionIdResourceGroupNameRegistryNameNameRegistriesRegenerateCredential', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'CredentialRegistryNameNameRegistriesRegenerateCredential' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-RegistryCredential_CredentialRegistryNameNameRegistriesRegenerateCredential', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'CredentialSubscriptionIdResourceGroupNameRegistryNameNameRegistriesRegenerateCredential' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-RegistryCredential_CredentialSubscriptionIdResourceGroupNameRegistryNameNameRegistriesRegenerateCredential', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'CredentialResourceGroupNameRegistryNameNameRegistriesRegenerateCredential' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-RegistryCredential_CredentialResourceGroupNameRegistryNameNameRegistriesRegenerateCredential', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'CredentialSubscriptionIdRegistryNameNameRegistriesRegenerateCredential' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-RegistryCredential_CredentialSubscriptionIdRegistryNameNameRegistriesRegenerateCredential', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-RegistryCredential_CredentialRegistryNameNameRegistriesRegenerateCredential', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName ContainerRegistryManagement.private\New-RegistryCredential_CredentialRegistryNameNameRegistriesRegenerateCredential
.ForwardHelpCategory Cmdlet

#>

}

