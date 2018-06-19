function Ping-Webhook {
[CmdletBinding(DefaultParameterSetName='RegistryNameWebhookNameWebhooksPing')]
param(
    [Parameter(ParameterSetName='RegistryNameWebhookNameWebhooksPing', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNameWebhooksPing', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNameWebhooksPing', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksPing', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='RegistryNameWebhookNameWebhooksPing', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNameWebhooksPing', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNameWebhooksPing', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksPing', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='RegistryNameWebhookNameWebhooksPing', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNameWebhooksPing', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNameWebhooksPing', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksPing', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [string]
    ${RegistryName},

    [Parameter(ParameterSetName='RegistryNameWebhookNameWebhooksPing', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNameWebhooksPing', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNameWebhooksPing', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksPing', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [string]
    ${WebhookName},

    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNameWebhooksPing', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksPing', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNameWebhooksPing', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksPing', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'SubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksPing' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Ping-Webhook_SubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksPing', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'RegistryNameWebhookNameWebhooksPing' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Ping-Webhook_RegistryNameWebhookNameWebhooksPing', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SubscriptionIdRegistryNameWebhookNameWebhooksPing' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Ping-Webhook_SubscriptionIdRegistryNameWebhookNameWebhooksPing', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ResourceGroupNameRegistryNameWebhookNameWebhooksPing' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Ping-Webhook_ResourceGroupNameRegistryNameWebhookNameWebhooksPing', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Ping-Webhook_RegistryNameWebhookNameWebhooksPing', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName ContainerRegistryManagement.private\Ping-Webhook_RegistryNameWebhookNameWebhooksPing
.ForwardHelpCategory Cmdlet

#>

}

