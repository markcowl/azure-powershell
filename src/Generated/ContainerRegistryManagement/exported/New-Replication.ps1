function New-Replication {
[CmdletBinding(DefaultParameterSetName='RegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate')]
param(
    [Parameter(ParameterSetName='RegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='RegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Rest.ClientRuntime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='RegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='The name of the container registry.')]
    [string]
    ${RegistryName},

    [Parameter(ParameterSetName='RegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='An object that represents a replication for a container registry.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='An object that represents a replication for a container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='An object that represents a replication for a container registry.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='An object that represents a replication for a container registry.')]
    [Sample.API.Models.IReplication]
    ${Replication},

    [Parameter(ParameterSetName='RegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='The name of the replication.')]
    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='The name of the replication.')]
    [Parameter(ParameterSetName='SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='The name of the replication.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='The name of the replication.')]
    [string]
    ${ReplicationName},

    [Parameter(ParameterSetName='ResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'SubscriptionIdResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-Replication_SubscriptionIdResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-Replication_SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'RegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-Replication_RegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-Replication_ResourceGroupNameRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('ContainerRegistryManagement.private\New-Replication_RegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName ContainerRegistryManagement.private\New-Replication_RegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate
.ForwardHelpCategory Cmdlet

#>

}

