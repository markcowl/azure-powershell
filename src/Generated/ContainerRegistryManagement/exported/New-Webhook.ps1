function New-Webhook {
[CmdletBinding(DefaultParameterSetName='RegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate')]
param(
    [Parameter(ParameterSetName='RegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='RegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='RegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [string]
    ${RegistryName},

    [Parameter(ParameterSetName='RegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The parameters for creating a webhook.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The parameters for creating a webhook.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The parameters for creating a webhook.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The parameters for creating a webhook.')]
    [Sample.API.Models.IWebhookCreateParameters]
    ${WebhookCreateParameters},

    [Parameter(ParameterSetName='RegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The name of the webhook.')]
    [string]
    ${WebhookName},

    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='SubscriptionIdRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'SubscriptionIdResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-Webhook_SubscriptionIdResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'RegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-Webhook_RegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SubscriptionIdRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-Webhook_SubscriptionIdRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-Webhook_ResourceGroupNameRegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-Webhook_RegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName ContainerRegistryManagement.private\New-Webhook_RegistryNameWebhookNameLocationPropertiesTagsWebhooksCreate
.ForwardHelpCategory Cmdlet

#>

}

