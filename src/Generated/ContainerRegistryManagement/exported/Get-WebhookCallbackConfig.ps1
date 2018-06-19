function Get-WebhookCallbackConfig {
[CmdletBinding(DefaultParameterSetName='CallbackConfigRegistryNameWebhookNameWebhooksGetCallbackConfig')]
param(
    [Parameter(ParameterSetName='CallbackConfigRegistryNameWebhookNameWebhooksGetCallbackConfig', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='CallbackConfigResourceGroupNameRegistryNameWebhookNameWebhooksGetCallbackConfig', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='CallbackConfigSubscriptionIdRegistryNameWebhookNameWebhooksGetCallbackConfig', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='CallbackConfigSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksGetCallbackConfig', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='CallbackConfigRegistryNameWebhookNameWebhooksGetCallbackConfig', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='CallbackConfigResourceGroupNameRegistryNameWebhookNameWebhooksGetCallbackConfig', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='CallbackConfigSubscriptionIdRegistryNameWebhookNameWebhooksGetCallbackConfig', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='CallbackConfigSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksGetCallbackConfig', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='CallbackConfigRegistryNameWebhookNameWebhooksGetCallbackConfig', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='CallbackConfigResourceGroupNameRegistryNameWebhookNameWebhooksGetCallbackConfig', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='CallbackConfigSubscriptionIdRegistryNameWebhookNameWebhooksGetCallbackConfig', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='CallbackConfigSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksGetCallbackConfig', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [string]
    ${RegistryName},

    [Parameter(ParameterSetName='CallbackConfigRegistryNameWebhookNameWebhooksGetCallbackConfig', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [Parameter(ParameterSetName='CallbackConfigResourceGroupNameRegistryNameWebhookNameWebhooksGetCallbackConfig', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [Parameter(ParameterSetName='CallbackConfigSubscriptionIdRegistryNameWebhookNameWebhooksGetCallbackConfig', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [Parameter(ParameterSetName='CallbackConfigSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksGetCallbackConfig', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [string]
    ${WebhookName},

    [Parameter(ParameterSetName='CallbackConfigResourceGroupNameRegistryNameWebhookNameWebhooksGetCallbackConfig', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='CallbackConfigSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksGetCallbackConfig', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='CallbackConfigSubscriptionIdRegistryNameWebhookNameWebhooksGetCallbackConfig', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='CallbackConfigSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksGetCallbackConfig', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'CallbackConfigSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksGetCallbackConfig' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Get-WebhookCallbackConfig_CallbackConfigSubscriptionIdResourceGroupNameRegistryNameWebhookNameWebhooksGetCallbackConfig', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'CallbackConfigRegistryNameWebhookNameWebhooksGetCallbackConfig' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Get-WebhookCallbackConfig_CallbackConfigRegistryNameWebhookNameWebhooksGetCallbackConfig', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'CallbackConfigResourceGroupNameRegistryNameWebhookNameWebhooksGetCallbackConfig' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Get-WebhookCallbackConfig_CallbackConfigResourceGroupNameRegistryNameWebhookNameWebhooksGetCallbackConfig', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'CallbackConfigSubscriptionIdRegistryNameWebhookNameWebhooksGetCallbackConfig' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Get-WebhookCallbackConfig_CallbackConfigSubscriptionIdRegistryNameWebhookNameWebhooksGetCallbackConfig', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Get-WebhookCallbackConfig_CallbackConfigRegistryNameWebhookNameWebhooksGetCallbackConfig', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName ContainerRegistryManagement.private\Get-WebhookCallbackConfig_CallbackConfigRegistryNameWebhookNameWebhooksGetCallbackConfig
.ForwardHelpCategory Cmdlet

#>

}

