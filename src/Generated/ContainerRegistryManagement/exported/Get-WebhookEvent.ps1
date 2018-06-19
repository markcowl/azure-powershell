function Get-WebhookEvent {
[CmdletBinding(DefaultParameterSetName='EventsRegistryNameWebhookNameWebhooksListEvents')]
param(
    [Parameter(ParameterSetName='EventsRegistryNameWebhookNameWebhooksListEvents', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='EventsResourceGroupNameRegistryNameWebhookNameWebhooksListEvents', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='EventsSubscriptionIdRegistryNameWebhookNameWebhooksListEvents', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='EventsSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksListEvents', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='EventsRegistryNameWebhookNameWebhooksListEvents', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='EventsResourceGroupNameRegistryNameWebhookNameWebhooksListEvents', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='EventsSubscriptionIdRegistryNameWebhookNameWebhooksListEvents', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='EventsSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksListEvents', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='EventsRegistryNameWebhookNameWebhooksListEvents', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='EventsResourceGroupNameRegistryNameWebhookNameWebhooksListEvents', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='EventsSubscriptionIdRegistryNameWebhookNameWebhooksListEvents', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='EventsSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksListEvents', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [string]
    ${RegistryName},

    [Parameter(ParameterSetName='EventsRegistryNameWebhookNameWebhooksListEvents', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [Parameter(ParameterSetName='EventsResourceGroupNameRegistryNameWebhookNameWebhooksListEvents', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [Parameter(ParameterSetName='EventsSubscriptionIdRegistryNameWebhookNameWebhooksListEvents', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [Parameter(ParameterSetName='EventsSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksListEvents', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [string]
    ${WebhookName},

    [Parameter(ParameterSetName='EventsResourceGroupNameRegistryNameWebhookNameWebhooksListEvents', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='EventsSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksListEvents', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='EventsSubscriptionIdRegistryNameWebhookNameWebhooksListEvents', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='EventsSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksListEvents', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'EventsSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksListEvents' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Get-WebhookEvent_EventsSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksListEvents', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'EventsRegistryNameWebhookNameWebhooksListEvents' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Get-WebhookEvent_EventsRegistryNameWebhookNameWebhooksListEvents', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'EventsResourceGroupNameRegistryNameWebhookNameWebhooksListEvents' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Get-WebhookEvent_EventsResourceGroupNameRegistryNameWebhookNameWebhooksListEvents', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'EventsSubscriptionIdRegistryNameWebhookNameWebhooksListEvents' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Get-WebhookEvent_EventsSubscriptionIdRegistryNameWebhookNameWebhooksListEvents', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Get-WebhookEvent_EventsRegistryNameWebhookNameWebhooksListEvents', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName ContainerRegistryManagement.private\Get-WebhookEvent_EventsRegistryNameWebhookNameWebhooksListEvents
.ForwardHelpCategory Cmdlet

#>

}

