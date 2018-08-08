#
# Module manifest for module 'PSGet_AzureRM.DataFactoryV2'
#
# Generated by: Microsoft Corporation
#
# Generated on: 7/24/2018
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '0.5.8'

# Supported PSEditions
# CompatiblePSEditions = @()

# ID used to uniquely identify this module
GUID = 'e3c0f6bc-fe96-41a0-88f4-5e490a91f05d'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - DataFactories service cmdlets for Azure Resource Manager'

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
RequiredModules = @(@{ModuleName = 'AzureRM.Profile'; ModuleVersion = '5.4.0'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = '.\Microsoft.Azure.Management.DataFactory.dll', 
               '.\Microsoft.DataTransfer.Gateway.Encryption.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = '.\Microsoft.Azure.Commands.DataFactoryV2.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('.\Microsoft.Azure.Commands.DataFactoryV2.dll')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'Set-AzureRmDataFactoryV2', 'Update-AzureRmDataFactoryV2', 
               'Get-AzureRmDataFactoryV2', 'Remove-AzureRmDataFactoryV2', 
               'Set-AzureRmDataFactoryV2LinkedService', 
               'New-AzureRmDataFactoryV2LinkedServiceEncryptedCredential', 
               'Get-AzureRmDataFactoryV2LinkedService', 
               'Remove-AzureRmDataFactoryV2LinkedService', 
               'Set-AzureRmDataFactoryV2Dataset', 
               'Get-AzureRmDataFactoryV2Dataset', 
               'Remove-AzureRmDataFactoryV2Dataset', 
               'Set-AzureRmDataFactoryV2Trigger', 
               'Get-AzureRmDataFactoryV2Trigger', 
               'Remove-AzureRmDataFactoryV2Trigger', 
               'Start-AzureRmDataFactoryV2Trigger', 
               'Stop-AzureRmDataFactoryV2Trigger', 
               'Set-AzureRmDataFactoryV2Pipeline', 
               'Get-AzureRmDataFactoryV2Pipeline', 
               'Remove-AzureRmDataFactoryV2Pipeline', 
               'Invoke-AzureRmDataFactoryV2Pipeline', 
               'Get-AzureRmDataFactoryV2PipelineRun', 
               'Stop-AzureRmDataFactoryV2PipelineRun', 
               'Get-AzureRmDataFactoryV2ActivityRun', 
               'Get-AzureRmDataFactoryV2IntegrationRuntimeKey', 
               'Get-AzureRmDataFactoryV2IntegrationRuntime', 
               'New-AzureRmDataFactoryV2IntegrationRuntimeKey', 
               'Remove-AzureRmDataFactoryV2IntegrationRuntime', 
               'Set-AzureRmDataFactoryV2IntegrationRuntime', 
               'Start-AzureRmDataFactoryV2IntegrationRuntime', 
               'Stop-AzureRmDataFactoryV2IntegrationRuntime', 
               'Get-AzureRmDataFactoryV2IntegrationRuntimeMetric', 
               'Remove-AzureRmDataFactoryV2IntegrationRuntimeNode', 
               'Update-AzureRmDataFactoryV2IntegrationRuntimeNode', 
               'Get-AzureRmDataFactoryV2IntegrationRuntimeNode', 
               'Invoke-AzureRmDataFactoryV2IntegrationRuntimeUpgrade', 
               'Sync-AzureRmDataFactoryV2IntegrationRuntimeCredential', 
               'Update-AzureRmDataFactoryV2IntegrationRuntime', 
               'Get-AzureRmDataFactoryV2TriggerRun'

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = 'New-AzureRmDataFactoryV2', 'New-AzureRmDataFactoryV2Dataset', 
               'New-AzureRmDataFactoryV2LinkedService', 
               'New-AzureRmDataFactoryV2Pipeline', 
               'New-AzureRmDataFactoryV2Trigger'

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
        Tags = 'Azure','ResourceManager','ARM','DataFactory'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '* Updated all help files to include full parameter types and correct input/output types.
* Updated the ADF .Net SDK version to 1.1.0.
* Support self-hosted integration runtime sharing across data factories.
     - Add new parameter -SharedIntegrationRuntimeResourceId to Set-AzureRmDataFactoryV2IntegrationRuntime cmdlet.
     - Add new optional parameter -LinkedDataFactoryName to Remove-AzureRmDataFactoryV2IntegrationRuntime cmdlet.'

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

