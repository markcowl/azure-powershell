#
# Module manifest for module 'Az'
#
# Generated by: Microsoft Corporation
#
# Generated on: 9/17/2019
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '2.7.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'd48d710e-85cb-46a1-990f-22dae76f6b5f'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Cmdlets to manage resources in Azure. This module is compatible with WindowsPowerShell and PowerShell Core.

For more information about the Az module, please visit the following: https://docs.microsoft.com/en-us/powershell/azure/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '1.6.2'; }, 
               @{ModuleName = 'Az.Advisor'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.Aks'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.AnalysisServices'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.ApiManagement'; RequiredVersion = '1.3.1'; }, 
               @{ModuleName = 'Az.ApplicationInsights'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Automation'; RequiredVersion = '1.3.3'; }, 
               @{ModuleName = 'Az.Batch'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.Billing'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.Cdn'; RequiredVersion = '1.3.1'; }, 
               @{ModuleName = 'Az.CognitiveServices'; RequiredVersion = '1.2.1'; }, 
               @{ModuleName = 'Az.Compute'; RequiredVersion = '2.5.1'; }, 
               @{ModuleName = 'Az.ContainerInstance'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.ContainerRegistry'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.DataFactory'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.DataLakeAnalytics'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.DataLakeStore'; RequiredVersion = '1.2.2'; }, 
               @{ModuleName = 'Az.DeploymentManager'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.DevTestLabs'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Dns'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.EventGrid'; RequiredVersion = '1.2.2'; }, 
               @{ModuleName = 'Az.EventHub'; RequiredVersion = '1.4.0'; }, 
               @{ModuleName = 'Az.FrontDoor'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.HDInsight'; RequiredVersion = '2.0.2'; }, 
               @{ModuleName = 'Az.IotHub'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.KeyVault'; RequiredVersion = '1.3.1'; }, 
               @{ModuleName = 'Az.LogicApp'; RequiredVersion = '1.3.1'; }, 
               @{ModuleName = 'Az.MachineLearning'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.ManagedServices'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.MarketplaceOrdering'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.Media'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Monitor'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.Network'; RequiredVersion = '1.14.0'; }, 
               @{ModuleName = 'Az.NotificationHubs'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.OperationalInsights'; RequiredVersion = '1.3.3'; }, 
               @{ModuleName = 'Az.PolicyInsights'; RequiredVersion = '1.1.3'; }, 
               @{ModuleName = 'Az.PowerBIEmbedded'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.RecoveryServices'; RequiredVersion = '1.4.5'; }, 
               @{ModuleName = 'Az.RedisCache'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Relay'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Resources'; RequiredVersion = '1.7.0'; }, 
               @{ModuleName = 'Az.ServiceBus'; RequiredVersion = '1.4.0'; }, 
               @{ModuleName = 'Az.ServiceFabric'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.SignalR'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Sql'; RequiredVersion = '1.14.2'; }, 
               @{ModuleName = 'Az.Storage'; RequiredVersion = '1.7.0'; }, 
               @{ModuleName = 'Az.StorageSync'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.StreamAnalytics'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.TrafficManager'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Websites'; RequiredVersion = '1.4.2'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ARM','ResourceManager','Linux','AzureAutomationNotSupported'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '2.7.0 - September 2019
Az.ApiManagement
* Update ''-Format'' parameter description in ''Set-AzApiManagementPolicy'' reference documentation
* Removed references of deprecated cmdlet ''Update-AzApiManagementDeployment'' from reference documentation. Use ''Set-AzApiManagement'' instead.

Az.Automation
* Fixed example typo in reference documentation for ''Register-AzAutomationDscNode''
* Added clarification on OS restriction to Register-AzAutomationDSCNode
* Fixed Start-AzAutomationRunbook cmdlet Null reference exception for -Wait option.

Az.Compute
* Fix the null exception for Get-AzRemoteDesktopFile.
* Fix VHD Seek method for end-relative position.
* Fix UltraSSD issue for New-AzVM and Update-AzVM.

Az.DataFactory
* Adding 3 new commands for ADF V2 - Add-AzDataFactoryV2TriggerSubscription, Remove-AzDataFactoryV2TriggerSubscription, and Get-AzDataFactoryV2TriggerSubscriptionStatus

Az.HDInsight
* Call out breaking changes

Az.IotHub
* Add support to invoke failover for an IotHub to the geo-paired disaster recovery region.

Az.Monitor
* Pointing to the most recent Monitor SDK, i.e. 0.24.1-preview
   - Adds non-braking changes to the Metrics cmdlets, i.e. the Unit enumeration supports several new values. These are read-only cmdlets, so there would be no change in the input of the cmdlets.
   - The api-version of the **ActionGroups** requests is now **2019-06-01**, before it was **2018-03-01**. The scenario tests have been updated to accommodate for this change.
   - The constructors for the classes **EmailReceiver** and **WebhookReceiver** added one new mandatory argument, i.e. a Boolean value called **useCommonAlertSchema**. Currently, the value is fixed to **false** to hide this breaking change from the cmdlets. **NOTE**: this is a temporary change that must be validated by the Alerts team.
   - The order of the arguments for the constructor of the class **Source** (related to the **ScheduledQueryRuleSource** class) changed from the previous SDK. This change required two unit tests to the be fixed: they compiled, but failed to pass the tests.
   - The order of the arguments for the constructor of the class **AlertingAction** (related to the **ScheduledQueryRuleSource** class) changed from the previous SDK. This change required two unit tests to the be fixed: they compiled, but failed to pass the tests.
* Support Dynamic Threshold criteria for metric alert V2
	- New-AzMetricAlertRuleV2Criteria: now creats dynamic threshold criteria also
	- Add-AzMetricAlertRuleV2: now accept dynamic threshold criteria also
* Improvements in Scheduled Query Rule cmdlets (SQR)
 - Cmdlets will accept ''Location'' paramater in both formats, either the location (e.g. eastus) or the location display name (e.g. East US)
 - Illustrated ''Enabled'' parameter in help files properly
 - Added examples for ''ActionGroup'' optional parameter
 - Overall improved help files
* Fix bug in determining scope type for ''Set-AzActionRule''

Az.Network
* Fix incorrect example in ''New-AzApplicationGateway'' reference documentation 
* Add note in ''Get-AzNetworkWatcherPacketCapture'' reference documentation about retrieving all properties for a packet capture
* Fixed example in ''Test-AzNetworkWatcherIPFlow'' reference documentation to correctly enumerate NICs
* Improved cloud exception parsing to display additional details if they are present
* Improved cloud exception parsing to handle additional type of SDK exception
* Fixed incorrect mapping of Security Rule models
* Added properties to network interface for private ip feature
    - Added property ''PrivateEndpoint'' as type of PSResourceId to PSNetworkInterface
    - Added property ''PrivateLinkConnectionProperties'' as type of PSIpConfigurationConnectivityInformation to PSNetworkInterfaceIPConfiguration
    - Added new model class PSIpConfigurationConnectivityInformation
* Added new ApplicationRuleProtocolType ''mssql'' for Azure Firewall resource
* MultiLink support in Virtual WAN
    - New cmdlets
        - New-AzVpnSiteLink
        - New-AzVpnSiteLinkConnection
    - Updated cmdlet:
        - New-VpnSite
        - Update-VpnSite
        - New-VpnConnection
        - Update-VpnConnection
* Fixed documents for some PowerShell examples to use Az cmdlets instead of AzureRM cmdlets

Az.RecoveryServices
* Update AzureVMpolicy Object with ProtectedItemsCount Attribute
* Added Tests for VM policy and Original Storage Account Restore

Az.Resources
* Fix bug where New-AzRoleAssignment could not be called without parameter Scope.

Az.ServiceFabric
* Fixed typo in example for ''Update-AzServiceFabricReliability'' reference documentation
* Adding new cmdlets to manage appliaction and services:
    - New-AzServiceFabricApplication
    - New-AzServiceFabricApplicationType
    - New-AzServiceFabricApplicationTypeVersion
    - New-AzServiceFabricService
    - Update-AzServiceFabricApplication
    - Get-AzServiceFabricApplication
    - Get-AzServiceFabricApplicationType
    - Get-AzServiceFabricApplicationTypeVersion
    - Get-AzServiceFabricService
    - Remove-AzServiceFabricApplication
    - Remove-AzServiceFabricApplicationType
    - Remove-AzServiceFabricApplicationTypeVersion
    - Remove-AzServiceFabricServic
* Upgraded Service Fabric SDK to version 1.2.0 which uses service fabric resource provider api-version 2019-03-01.

Az.SignalR
* Add Update, Restart, CheckNameAvailability, GetUsage Cmdlets

Az.Sql
* Update example in reference documentation for ''Get-AzSqlElasticPool''
* Added vCore example to creating an elastic pool (New-AzSqlElasticPool).
* Remove the validation of EmailAddresses and the check that EmailAdmins is not false in case EmailAddresses is empty in Set-AzSqlServerAdvancedThreatProtectionPolicy and Set-AzSqlDatabaseAdvancedThreatProtectionPolicy
* Enabled removal of server/database auditing settings when multiple diagnostic settings that enable audit category exist.
* Fix email addresses validation in multiple Sql Vulnerability Assessment cmdlets (Update-AzSqlDatabaseVulnerabilityAssessmentSetting, Update-AzSqlServerVulnerabilityAssessmentSetting, Update-AzSqlInstanceDatabaseVulnerabilityAssessmentSetting and Update-AzSqlInstanceVulnerabilityAssessmentSetting).

Az.Storage
* Updated example in reference documentation for ''Get-AzStorageAccountKey''
* In upload/Downalod Azure File,support perserve the source File SMB properties (File Attributtes, File Creation Time, File Last Write Time) in the destination file
    -  Set-AzStorageFileContent
    -  Get-AzStorageFileContent
* Fix Upload block blob with properties/metadate fail on container enabled ImmutabilityPolicy.
    -  Set-AzStorageBlobContent
* Support manage Azure File shares with Management plane API
    -  New-AzRmStorageShare
    -  Get-AzRmStorageShare
    -  Update-AzRmStorageShare
    -  Remove-AzRmStorageShare

Az.Websites
* Fixing issue where webapp Tags were getting deleted when migrating App to new ASPwhere webapp Tags were getting deleted when migrating App to new ASP
* Fixing the Publish-AzureWebapp to work across Linux and windows
* Update example in ''Get-AzWebAppPublishingProfile'' reference documentation
'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

