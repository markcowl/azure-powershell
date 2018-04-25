#
# Module manifest for module 'PSGet_AzureRM'
#
# Generated by: Microsoft Corporation
#
# Generated on: 4/24/2018
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '6.0.0'

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
               @{ModuleName = 'Azure.AnalysisServices'; RequiredVersion = '0.5.1'; }, 
               @{ModuleName = 'AzureRM.ApiManagement'; RequiredVersion = '6.0.0'; }, 
               @{ModuleName = 'AzureRM.ApplicationInsights'; RequiredVersion = '0.1.4'; }, 
               @{ModuleName = 'AzureRM.Automation'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'AzureRM.Backup'; RequiredVersion = '4.0.5'; }, 
               @{ModuleName = 'AzureRM.Batch'; RequiredVersion = '4.0.7'; }, 
               @{ModuleName = 'AzureRM.Billing'; RequiredVersion = '0.14.2'; }, 
               @{ModuleName = 'AzureRM.Cdn'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'AzureRM.CognitiveServices'; RequiredVersion = '0.9.5'; }, 
               @{ModuleName = 'AzureRM.Compute'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'AzureRM.Consumption'; RequiredVersion = '0.3.2'; }, 
               @{ModuleName = 'AzureRM.ContainerInstance'; RequiredVersion = '0.2.6'; }, 
               @{ModuleName = 'AzureRM.ContainerRegistry'; RequiredVersion = '1.0.5'; }, 
               @{ModuleName = 'AzureRM.DataFactories'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'AzureRM.DataFactoryV2'; RequiredVersion = '0.5.4'; }, 
               @{ModuleName = 'AzureRM.DataLakeAnalytics'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'AzureRM.DataLakeStore'; RequiredVersion = '6.0.0'; }, 
               @{ModuleName = 'AzureRM.DevTestLabs'; RequiredVersion = '4.0.5'; }, 
               @{ModuleName = 'AzureRM.Dns'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'AzureRM.EventGrid'; RequiredVersion = '0.3.3'; }, 
               @{ModuleName = 'AzureRM.EventHub'; RequiredVersion = '0.6.4'; }, 
               @{ModuleName = 'AzureRM.HDInsight'; RequiredVersion = '4.1.3'; }, 
               @{ModuleName = 'AzureRM.Insights'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'AzureRM.IotHub'; RequiredVersion = '3.1.3'; }, 
               @{ModuleName = 'AzureRM.KeyVault'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'AzureRM.LogicApp'; RequiredVersion = '4.0.4'; }, 
               @{ModuleName = 'AzureRM.MachineLearning'; RequiredVersion = '0.18.0'; }, 
               @{ModuleName = 'AzureRM.MachineLearningCompute'; RequiredVersion = '0.4.3'; }, 
               @{ModuleName = 'AzureRM.MarketplaceOrdering'; RequiredVersion = '0.2.2'; }, 
               @{ModuleName = 'AzureRM.Media'; RequiredVersion = '0.10.0'; }, 
               @{ModuleName = 'AzureRM.Network'; RequiredVersion = '6.0.0'; }, 
               @{ModuleName = 'AzureRM.NotificationHubs'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'AzureRM.OperationalInsights'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'AzureRM.PowerBIEmbedded'; RequiredVersion = '4.1.5'; }, 
               @{ModuleName = 'AzureRM.RecoveryServices'; RequiredVersion = '4.1.3'; }, 
               @{ModuleName = 'AzureRM.RecoveryServices.Backup'; RequiredVersion = '4.1.3'; }, 
               @{ModuleName = 'AzureRM.RecoveryServices.SiteRecovery'; RequiredVersion = '0.2.5'; }, 
               @{ModuleName = 'AzureRM.RedisCache'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'AzureRM.Relay'; RequiredVersion = '0.3.4'; }, 
               @{ModuleName = 'AzureRM.Resources'; RequiredVersion = '6.0.0'; }, 
               @{ModuleName = 'AzureRM.Scheduler'; RequiredVersion = '0.16.4'; }, 
               @{ModuleName = 'AzureRM.ServiceBus'; RequiredVersion = '0.6.5'; }, 
               @{ModuleName = 'AzureRM.ServiceFabric'; RequiredVersion = '0.3.5'; }, 
               @{ModuleName = 'AzureRM.Sql'; RequiredVersion = '4.4.1'; }, 
               @{ModuleName = 'AzureRM.Storage'; RequiredVersion = '5.0.0'; }, 
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
        ReleaseNotes = '6.0.0 - May 2018

General
* Set minimum dependency of modules to PowerShell 5.0

Azure.Storage
* Support  as Storage blob container name
	- New-AzureStorageBlobContainer
	- Remove-AzureStorageBlobContainer
	- Set-AzureStorageBlobContent
	- Get-AzureStorageBlobContent
* Fix the issue that some Storage cmdlets failure output not contain detail failure information

AzureRM.ApiManagement
* Introduce multiple breaking changes
    - Please refer to the migration guide for more information

AzureRM.Automation
* Remove deprecated ''Tags'' alias from cmdlets
    - ''Set-AzureRmAutomationRunbook''

AzureRM.Batch
* Updated New-AzureBatchPool documentation to remove deprecated example

AzureRM.Cdn
* Introduce multiple breaking changes
    - Please refer to the migration guide for more information

AzureRM.Compute
* ''New-AzureRmVm'' and ''New-AzureRmVmss'' support verbose output of parameters
* ''New-AzureRmVm'' and ''New-AzureRmVmss'' (simple parameter set) support assigning user defined and(or) system defined identities to the VM(s).
* VMSS Redeploy and PerformMaintenance feature
    -  Add new switch parameter -Redeploy and -PerformMaintenance to ''Set-AzureRmVmss'' and ''Set-AzureRmVmssVM''
* Add DisableVMAgent switch parameter to ''Set-AzureRmVMOperatingSystem'' cmdlet
* ''New-AzureRmVm'' and ''New-AzureRmVmss'' (simple parameter set) support a ''Win10'' image.
* ''Repair-AzureRmVmssServiceFabricUpdateDomain'' cmdlet is added.
* Introduce multiple breaking changes
    - Please refer to the migration guide for more details

AzureRM.DataFactories
* Remove deprecated ''Tags'' alias from cmdlets
    - New-AzureRmDataFactory

AzureRM.DataFactoryV2
* Updated the ADF .Net SDK version to 0.7.0-preview containing following changes:
    - Added execution parameters and connection managers property on ExecuteSSISPackage Activity
    - Updated PostgreSql, MySql llinked service to use full connection string instead of server, database, schema, username and password
    - Removed the schema from DB2 linked service
    - Removed schema property from Teradata linked service
    - Added LinkedService, Dataset, CopySource for Responsys

AzureRM.DataLakeStore
* Breaking changes in Export-AzureRmDataLakeStoreItem, Import-AzureRmDataLakeStoreItem, Remove-AzureRmDataLakeStoreItem

AzureRM.Dns
* Introduce multiple breaking changes
    - Please refer to the migration guide for more information

AzureRM.EventHub
* Updated Help for cmdlets with missing examples

AzureRM.Insights
* Introduced multiple breaking changes
    - Please refer to the migration guide for more information

AzureRM.KeyVault
* Breaking changes to support piping scenarios
* Added new cmdlets: Backup/Restore-AzureKeyVaultManagedStorageAccount, Backup/Restore-AzureKeyVaultCertificate, Undo-AzureKeyVaultManagedStorageSasDefinitionRemoval, and Undo-AzureKeyVaultManagedStorageAccountRemoval

AzureRM.MachineLearning
* Remove deprecated ''Tags'' alias from cmdlets
    - Update-AzureRmMlCommitmentPlan

AzureRM.Media
* Remove deprecated ''Tags'' alias from cmdlets
    - ''Set-AzureRmMediaService''

AzureRM.Network
* Introduced multiple breaking changes
    - Please refer to the migration guide for more information

AzureRM.NotificationHubs
* Introduce multiple breaking changes
    - Please refer to the migration guide for more information

AzureRM.OperationalInsights
* Introduce multiple breaking changes
    - Please refer to the migration guide for more information

AzureRM.RedisCache
* Introduced multiple breaking changes
    - Please refer to the migration guide for more information

AzureRM.Resources
* Remove obsolete parameter -AtScopeAndBelow from Get-AzureRmRoledefinition call
* Include assignments to deleted USers/Groups/ServicePrincipals in Get-AzureRmRoleAssignment result

AzureRM.ServiceFabric
* Update default Linux image version sku
  - NewAzureServiceFabricCluster.cs default UbuntuServer1604 Sku update

AzureRM.Storage
* Updated to the latest version of the Azure ClientRuntime
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

