function Update-Replication {
[CmdletBinding(DefaultParameterSetName='RegistryNameReplicationNameTagsReplicationsUpdate')]
param(
    [Parameter(ParameterSetName='RegistryNameReplicationNameTagsReplicationsUpdate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameReplicationNameTagsReplicationsUpdate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='RegistryNameReplicationNameTagsReplicationsUpdate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameReplicationNameTagsReplicationsUpdate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='RegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [string]
    ${RegistryName},

    [Parameter(ParameterSetName='RegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The name of the replication.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The name of the replication.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The name of the replication.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The name of the replication.')]
    [string]
    ${ReplicationName},

    [Parameter(ParameterSetName='RegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The parameters for updating a replication.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The parameters for updating a replication.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The parameters for updating a replication.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The parameters for updating a replication.')]
    [Sample.API.Models.IReplicationUpdateParameters]
    ${ReplicationUpdateParameters},

    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='SubscriptionIdRegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'SubscriptionIdResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Update-Replication_SubscriptionIdResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'RegistryNameReplicationNameTagsReplicationsUpdate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Update-Replication_RegistryNameReplicationNameTagsReplicationsUpdate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Update-Replication_ResourceGroupNameRegistryNameReplicationNameTagsReplicationsUpdate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SubscriptionIdRegistryNameReplicationNameTagsReplicationsUpdate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Update-Replication_SubscriptionIdRegistryNameReplicationNameTagsReplicationsUpdate', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\Update-Replication_RegistryNameReplicationNameTagsReplicationsUpdate', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName ContainerRegistryManagement.private\Update-Replication_RegistryNameReplicationNameTagsReplicationsUpdate
.ForwardHelpCategory Cmdlet

#>

}

