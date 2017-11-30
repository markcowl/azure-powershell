#  
# Module manifest for module 'AzureRM'  
#  
# Generated by: Microsoft Corporation  
#  
# Generated on: 11/27/2017 15:16:56
#  

$PSDefaultParameterValues.Clear()
Set-StrictMode -Version Latest

Import-Module AzureRM.Profile -RequiredVersion 4.0.0
Import-Module Azure.Storage -RequiredVersion 4.0.0
Import-Module AzureRM.AnalysisServices -RequiredVersion 0.5.0
Import-Module Azure.AnalysisServices -RequiredVersion 0.5.0
Import-Module AzureRM.ApiManagement -RequiredVersion 5.0.1
Import-Module AzureRM.ApplicationInsights -RequiredVersion 0.1.0
Import-Module AzureRM.Automation -RequiredVersion 4.0.0
Import-Module AzureRM.Backup -RequiredVersion 4.0.1
Import-Module AzureRM.Batch -RequiredVersion 4.0.1
Import-Module AzureRM.Billing -RequiredVersion 0.14.0
Import-Module AzureRM.Cdn -RequiredVersion 4.0.0
Import-Module AzureRM.CognitiveServices -RequiredVersion 0.9.0
Import-Module AzureRM.Compute -RequiredVersion 4.0.1
Import-Module AzureRM.Consumption -RequiredVersion 0.3.0
Import-Module AzureRM.ContainerInstance -RequiredVersion 0.1.0
Import-Module AzureRM.ContainerRegistry -RequiredVersion 0.3.0
Import-Module AzureRM.DataFactories -RequiredVersion 4.0.1
Import-Module AzureRM.DataFactoryV2 -RequiredVersion 0.3.0
Import-Module AzureRM.DataLakeAnalytics -RequiredVersion 4.0.0
Import-Module AzureRM.DataLakeStore -RequiredVersion 5.0.0
Import-Module AzureRM.DevTestLabs -RequiredVersion 4.0.0
Import-Module AzureRM.Dns -RequiredVersion 4.0.0
Import-Module AzureRM.EventGrid -RequiredVersion 0.2.0
Import-Module AzureRM.EventHub -RequiredVersion 0.5.0
Import-Module AzureRM.HDInsight -RequiredVersion 4.0.1
Import-Module AzureRM.Insights -RequiredVersion 4.0.0
Import-Module AzureRM.IoTHub -RequiredVersion 3.0.0
Import-Module AzureRM.KeyVault -RequiredVersion 4.0.1
Import-Module AzureRM.LogicApp -RequiredVersion 4.0.0
Import-Module AzureRM.MachineLearning -RequiredVersion 0.16.0
Import-Module AzureRM.MachineLearningCompute -RequiredVersion 0.2.0
Import-Module AzureRM.MarketplaceOrdering -RequiredVersion 0.2.0
Import-Module AzureRM.Media -RequiredVersion 0.8.0
Import-Module AzureRM.Network -RequiredVersion 5.0.0
Import-Module AzureRM.NotificationHubs -RequiredVersion 4.0.0
Import-Module AzureRM.OperationalInsights -RequiredVersion 4.0.0
Import-Module AzureRM.PowerBIEmbedded -RequiredVersion 4.0.0
Import-Module AzureRM.RecoveryServices -RequiredVersion 4.0.1
Import-Module AzureRM.RecoveryServices.Backup -RequiredVersion 4.0.1
Import-Module AzureRM.RecoveryServices.SiteRecovery -RequiredVersion 0.2.1
Import-Module AzureRM.RedisCache -RequiredVersion 4.0.1
Import-Module AzureRM.Relay -RequiredVersion 0.3.0
Import-Module AzureRM.Resources -RequiredVersion 5.0.0
Import-Module AzureRM.Scheduler -RequiredVersion 0.16.0
Import-Module AzureRM.ServerManagement -RequiredVersion 4.0.0
Import-Module AzureRM.ServiceBus -RequiredVersion 0.5.0
Import-Module AzureRM.ServiceFabric -RequiredVersion 0.3.0
Import-Module AzureRM.SiteRecovery -RequiredVersion 5.0.1
Import-Module AzureRM.Sql -RequiredVersion 4.0.1
Import-Module AzureRM.Storage -RequiredVersion 4.0.1
Import-Module AzureRM.StreamAnalytics -RequiredVersion 4.0.1
Import-Module AzureRM.Tags -RequiredVersion 4.0.0
Import-Module AzureRM.TrafficManager -RequiredVersion 4.0.0
Import-Module AzureRM.UsageAggregates -RequiredVersion 4.0.0
Import-Module AzureRM.Websites -RequiredVersion 4.0.0


if ($PSVersionTable.PSVersion.Major -ge 5)
{
    $completerCommands = @()
    
    $completerCommands | ForEach-Object {
        $completerObject = New-Object $_.AttributeType -ArgumentList $_.ArgumentList
        Register-ArgumentCompleter -CommandName $_.Command -ParameterName $_.Parameter -ScriptBlock {
            param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameter)
            
            $locations = $completerObject.GetCompleterValues()
            $locations | Where-Object { $_ -Like "$wordToComplete*" } | ForEach-Object { [System.Management.Automation.CompletionResult]::new($_, $_, 'ParameterValue', $_) }
        }
    }
}

$FilteredCommands = @()

$FilteredCommands | ForEach-Object {
	$global:PSDefaultParameterValues.Add($_,
		{
			$context = Get-AzureRmContext
			if (($context -ne $null) -and $context.ExtendedProperties.ContainsKey("Default Resource Group")) {
				$context.ExtendedProperties["Default Resource Group"]
			} 
		})
}
