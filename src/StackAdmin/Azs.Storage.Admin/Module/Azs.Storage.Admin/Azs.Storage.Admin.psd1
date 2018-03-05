<#
Copyright (c) Microsoft Corporation. All rights reserved.
Licensed under the MIT License. See License.txt in the project root for license information.
#>

#
# Module manifest for module 'Azs.Storage.Admin'
#
# Generated by: Microsoft
#
# Generated on: 2/16/2018
#

@{

# Script module or binary module file associated with this manifest.
RootModule = 'Azs.Storage.Admin.psm1'

# Version number of this module.
ModuleVersion = '0.1.0'

# Supported PSEditions
# CompatiblePSEditions = @()

# ID used to uniquely identify this module
GUID = 'eec34fde-3f4f-4759-aa52-c6a7b8857a4f'

# Author of this module
Author = 'Microsoft'

# Company or vendor of this module
CompanyName = 'Microsoft'

# Copyright statement for this module
Copyright = '(c) 2018 Microsoft. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Storage Admin Client'

# Minimum version of the Windows PowerShell engine required by this module
# PowerShellVersion = ''

# Name of the Windows PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the Windows PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# DotNetFrameworkVersion = ''

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
# RequiredModules = @()

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = '.\Generated.PowerShell.Commands\FormatFiles\Acquisition.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\BlobService.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\BlobServiceWritableSettings.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\Container.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\Farm.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\FarmList.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\LocalizableString.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\Metric.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\MetricAvailability.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\MetricDefinition.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\MetricDefinitionList.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\MetricList.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\MetricValue.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\MigrationParameters.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\MigrationResult.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\QueueService.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\Resource.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\Service.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\Share.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\StorageAccount.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\StorageAccountList.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\StorageCreationProperties.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\StorageQuota.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\StorageQuotaList.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\TableService.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\WritableServiceSettings.ps1xml',
               '.\Generated.PowerShell.Commands\FormatFiles\WritableSettings.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('PSSwaggerUtility')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = 'Restore-AzsStorageAccount', 'New-AzsStorageQuota',
               'Get-AzsStorageFarmMetricDefinition',
               'Get-AzsQueueServiceMetricDefinition', 'Get-AzsBlobServiceMetric',
               'Get-AzsStorageShare', 'Get-AzsStorageAcquisition',
               'Get-AzsTableServiceMetric', 'Start-AzsReclaimStorageCapacity',
               'Get-AzsStorageShareMetric', 'Get-AzsDestinationShare',
               'Get-AzsBlobService', 'Get-AzsStorageContainer',
               'Get-AzsStorageShareMetricDefinition', 'Get-AzsStorageAccount',
               'Get-AzsStorageQuota', 'Get-AzsStorageContainerMigration',
               'Get-AzsQueueServiceMetric',
               'Start-AzsStorageContainerMigration', 'Get-AzsStorageFarm',
               'Remove-AzsStorageQuota', 'Set-AzsStorageQuota',
               'Get-AzsBlobServiceMetricDefinition', 'Get-AzsTableService',
               'Get-AzsTableServiceMetricDefinition',
               'Get-AzsReclaimStorageCapacityStatus', 'Get-AzsQueueService',
               'Get-AzsStorageFarmMetric', 'Stop-AzsContainerMigration'

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
        # LicenseUri = ''

        # A URL to the main website for this project.
        # ProjectUri = ''

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        # ReleaseNotes = ''

    } # End of PSData hashtable

} # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}


