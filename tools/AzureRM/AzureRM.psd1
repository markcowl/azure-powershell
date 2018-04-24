#
# Module manifest for module 'PSGet_AzureRM'
#
# Generated by: Microsoft Corporation
#
# Generated on: 4/3/2018
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '5.7.0'

# Supported PSEditions
# CompatiblePSEditions = @()

# ID used to uniquely identify this module
GUID = 'b433e830-b479-4f7f-9c80-9cc6c28e1b51'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Azure Resource Manager Module'

# Minimum version of the Windows PowerShell engine required by this module
PowerShellVersion = '5.0'

# Name of the Windows PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the Windows PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.5.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
CLRVersion = '4.0'

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'AzureRM.Profile'; RequiredVersion = '4.6.1'; }, 
               @{ModuleName = 'Azure.Storage'; RequiredVersion = '4.2.2'; }, 
               @{ModuleName = 'AzureRM.AnalysisServices'; RequiredVersion = '0.6.7'; }, 
               @{ModuleName = 'Azure.AnalysisServices'; RequiredVersion = '0.5.0'; }, 
               @{ModuleName = 'AzureRM.ApiManagement'; RequiredVersion = '5.2.0'; }, 
               @{ModuleName = 'AzureRM.ApplicationInsights'; RequiredVersion = '0.1.4'; }, 
               @{ModuleName = 'AzureRM.Automation'; RequiredVersion = '4.4.0'; }, 
               @{ModuleName = 'AzureRM.Backup'; RequiredVersion = '4.0.5'; }, 
               @{ModuleName = 'AzureRM.Batch'; RequiredVersion = '4.0.7'; }, 
               @{ModuleName = 'AzureRM.Billing'; RequiredVersion = '0.14.2'; }, 
               @{ModuleName = 'AzureRM.Cdn'; RequiredVersion = '4.3.0'; }, 
               @{ModuleName = 'AzureRM.CognitiveServices'; RequiredVersion = '0.9.5'; }, 
               @{ModuleName = 'AzureRM.Compute'; RequiredVersion = '4.7.0'; }, 
               @{ModuleName = 'AzureRM.Consumption'; RequiredVersion = '0.3.2'; }, 
               @{ModuleName = 'AzureRM.ContainerInstance'; RequiredVersion = '0.2.6'; }, 
               @{ModuleName = 'AzureRM.ContainerRegistry'; RequiredVersion = '1.0.5'; }, 
               @{ModuleName = 'AzureRM.DataFactories'; RequiredVersion = '4.3.0'; }, 
               @{ModuleName = 'AzureRM.DataFactoryV2'; RequiredVersion = '0.5.4'; }, 
               @{ModuleName = 'AzureRM.DataLakeAnalytics'; RequiredVersion = '4.2.4'; }, 
               @{ModuleName = 'AzureRM.DataLakeStore'; RequiredVersion = '5.3.0'; }, 
               @{ModuleName = 'AzureRM.DevTestLabs'; RequiredVersion = '4.0.5'; }, 
               @{ModuleName = 'AzureRM.Dns'; RequiredVersion = '4.2.0'; }, 
               @{ModuleName = 'AzureRM.EventGrid'; RequiredVersion = '0.3.3'; }, 
               @{ModuleName = 'AzureRM.EventHub'; RequiredVersion = '0.6.4'; }, 
               @{ModuleName = 'AzureRM.HDInsight'; RequiredVersion = '4.1.3'; }, 
               @{ModuleName = 'AzureRM.Insights'; RequiredVersion = '4.1.0'; }, 
               @{ModuleName = 'AzureRM.IotHub'; RequiredVersion = '3.1.3'; }, 
               @{ModuleName = 'AzureRM.KeyVault'; RequiredVersion = '4.4.0'; }, 
               @{ModuleName = 'AzureRM.LogicApp'; RequiredVersion = '4.0.4'; }, 
               @{ModuleName = 'AzureRM.MachineLearning'; RequiredVersion = '0.17.3'; }, 
               @{ModuleName = 'AzureRM.MachineLearningCompute'; RequiredVersion = '0.4.3'; }, 
               @{ModuleName = 'AzureRM.MarketplaceOrdering'; RequiredVersion = '0.2.2'; }, 
               @{ModuleName = 'AzureRM.Media'; RequiredVersion = '0.9.3'; }, 
               @{ModuleName = 'AzureRM.Network'; RequiredVersion = '5.5.0'; }, 
               @{ModuleName = 'AzureRM.NotificationHubs'; RequiredVersion = '4.2.0'; }, 
               @{ModuleName = 'AzureRM.OperationalInsights'; RequiredVersion = '4.4.0'; }, 
               @{ModuleName = 'AzureRM.PowerBIEmbedded'; RequiredVersion = '4.1.5'; }, 
               @{ModuleName = 'AzureRM.RecoveryServices'; RequiredVersion = '4.1.3'; }, 
               @{ModuleName = 'AzureRM.RecoveryServices.Backup'; RequiredVersion = '4.1.3'; }, 
               @{ModuleName = 'AzureRM.RecoveryServices.SiteRecovery'; RequiredVersion = '0.2.5'; }, 
               @{ModuleName = 'AzureRM.RedisCache'; RequiredVersion = '4.2.0'; }, 
               @{ModuleName = 'AzureRM.Relay'; RequiredVersion = '0.3.4'; }, 
               @{ModuleName = 'AzureRM.Resources'; RequiredVersion = '5.6.0'; }, 
               @{ModuleName = 'AzureRM.Scheduler'; RequiredVersion = '0.16.4'; }, 
               @{ModuleName = 'AzureRM.ServiceBus'; RequiredVersion = '0.6.5'; }, 
               @{ModuleName = 'AzureRM.ServiceFabric'; RequiredVersion = '0.3.5'; }, 
               @{ModuleName = 'AzureRM.Sql'; RequiredVersion = '4.4.1'; }, 
               @{ModuleName = 'AzureRM.Storage'; RequiredVersion = '4.3.0'; }, 
               @{ModuleName = 'AzureRM.StreamAnalytics'; RequiredVersion = '4.0.5'; }, 
               @{ModuleName = 'AzureRM.Tags'; RequiredVersion = '4.0.2'; }, 
               @{ModuleName = 'AzureRM.TrafficManager'; RequiredVersion = '4.0.4'; }, 
               @{ModuleName = 'AzureRM.UsageAggregates'; RequiredVersion = '4.0.3'; }, 
               @{ModuleName = 'AzureRM.Websites'; RequiredVersion = '4.2.3'; })

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
        # Tags = @()

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '5.7.0 - April 2018
General
* Updated to the latest version of the Azure ClientRuntime
        
Azure.Storage
* Fix the issue that upload Blob and upload File cmdlets fail on FIPS policy enabled machines
    - Set-AzureStorageBlobContent
    - Set-AzureStorageFileContent
        
AzureRM.Billing
* New Cmdlet Get-AzureRmEnrollmentAccount
    - cmdlet to retrieve enrollment accounts
        
AzureRM.CognitiveServices
* Integrate with Cognitive Services Management SDK version 4.0.0.
* Add Get-AzureRmCognitiveServicesAccountUsage operation.
        
AzureRM.Compute
* `Get-AzureRmVmssDiskEncryptionStatus` supports encryption status at data disk level
* `Get-AzureRmVmssVmDiskEncryptionStatus` supports encryption status at data disk level
* Update for Zone Resilient
* ''New-AzureRmVm'' and ''New-AzureRmVmss'' (simple parameter set) support availability zones.
        
AzureRM.ContainerRegistry
* Decouple reliance on Commands.Resources.Rest and ARM/Storage SDKs.

AzureRM.DataLakeStore
* Add debug functionality
* Update the version of the ADLS dataplane SDK to 1.1.2
* Export-AzureRmDataLakeStoreItem - Deprecated parameters PerFileThreadCount, ConcurrentFileCount and introduced parameter Concurrency
* Import-AzureRMDataLakeStoreItem - Deprecated parametersPerFileThreadCount, ConcurrentFileCount and introduced parameter Concurrency
* Get-AzureRMDataLakeStoreItemContent - Fixed the tail behavior for contents greater than 4MB
* Set-AzureRMDataLakeStoreItemExpiry - Introduced new parameter set SetRelativeExpiry for setting relative expiration time
* Remove-AzureRmDataLakeStoreItem - Deprecated parameter Clean.

AzureRM.EventHub
* Fixed AlternameName in New-AzureRmEventHubGeoDRConfiguration

AzureRM.KeyVault
* Updated cmdlets to include piping scenarios
* Add deprecation messages for upcoming breaking change release
        
AzureRM.Network
* Fix error message with Network cmdlets
        
AzureRM.ServiceBus
* Added ''properties'' in CorrelationFilter of Rules to support customproperties
* updated New-AzureRmServiceBusGeoDRConfiguration help and fixed Rules cmdlet output
* Fixed auto-forward properties in New-AzureRmServiceBusQueue and New-AzureRmServiceBusSubscription cmdlet
        
AzureRM.Sql
* Add new cmdlet ''Stop-AzureRmSqlElasticPoolActivity'' to support canceling the asynchronous operations on elastic pool
* Update the response for cmdlets Get-AzureRmSqlDatabaseActivity and Get-AzureRmSqlElasticPoolActivity to reflect more information in the response
'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update
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

