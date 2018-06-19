function Update-Webhook {
[CmdletBinding(DefaultParameterSetName='RegistryNameWebhookNamePropertiesTagsWebhooksUpdate')]
param(
    [Parameter(ParameterSetName='RegistryNameWebhookNamePropertiesTagsWebhooksUpdate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='RegistryNameWebhookNamePropertiesTagsWebhooksUpdate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='RegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [string]
    ${RegistryName},

    [Parameter(ParameterSetName='RegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [string]
    ${WebhookName},

    [Parameter(ParameterSetName='RegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The parameters for updating a webhook.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The parameters for updating a webhook.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The parameters for updating a webhook.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The parameters for updating a webhook.')]
    [Sample.API.Models.IWebhookUpdateParameters]
    ${WebhookUpdateParameters},

    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'SubscriptionIdRegistryNameWebhookNamePropertiesTagsWebhooksUpdate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Update-Webhook_SubscriptionIdRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'RegistryNameWebhookNamePropertiesTagsWebhooksUpdate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Update-Webhook_RegistryNameWebhookNamePropertiesTagsWebhooksUpdate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SubscriptionIdResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Update-Webhook_SubscriptionIdResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Update-Webhook_ResourceGroupNameRegistryNameWebhookNamePropertiesTagsWebhooksUpdate', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Update-Webhook_RegistryNameWebhookNamePropertiesTagsWebhooksUpdate', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName ContainerRegistryManagement.private\Update-Webhook_RegistryNameWebhookNamePropertiesTagsWebhooksUpdate
.ForwardHelpCategory Cmdlet

#>

}

