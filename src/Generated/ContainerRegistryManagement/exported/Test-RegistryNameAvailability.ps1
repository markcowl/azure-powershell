function Test-RegistryNameAvailability {
[CmdletBinding(DefaultParameterSetName='NameAvailabilityNameTypeRegistriesCheckNameAvailability')]
param(
    [Parameter(ParameterSetName='NameAvailabilityNameTypeRegistriesCheckNameAvailability', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeRegistriesCheckNameAvailability', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='NameAvailabilityNameTypeRegistriesCheckNameAvailability', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeRegistriesCheckNameAvailability', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='NameAvailabilityNameTypeRegistriesCheckNameAvailability', Mandatory=$true, HelpMessage='A request to check whether a container registry name is available.')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeRegistriesCheckNameAvailability', Mandatory=$true, HelpMessage='A request to check whether a container registry name is available.')]
    [Sample.API.Models.IRegistryNameCheckRequest]
    ${RegistryNameCheckRequest},

    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeRegistriesCheckNameAvailability', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'NameAvailabilitySubscriptionIdNameTypeRegistriesCheckNameAvailability' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Test-RegistryNameAvailability_NameAvailabilitySubscriptionIdNameTypeRegistriesCheckNameAvailability', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'NameAvailabilityNameTypeRegistriesCheckNameAvailability' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Test-RegistryNameAvailability_NameAvailabilityNameTypeRegistriesCheckNameAvailability', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Test-RegistryNameAvailability_NameAvailabilityNameTypeRegistriesCheckNameAvailability', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName ContainerRegistryManagement.private\Test-RegistryNameAvailability_NameAvailabilityNameTypeRegistriesCheckNameAvailability
.ForwardHelpCategory Cmdlet

#>

}

