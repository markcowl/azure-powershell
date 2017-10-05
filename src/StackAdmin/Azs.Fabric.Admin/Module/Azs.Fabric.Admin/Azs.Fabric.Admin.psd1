<#
The MIT License (MIT)

Copyright (c) 2017 Microsoft

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
#>

#
# Module manifest for module 'Azs.Fabric.Admin'
#
# Generated by: jerobins
#
# Generated on: 9/5/2017
#

@{

# Script module or binary module file associated with this manifest.
RootModule = 'Azs.Fabric.Admin.psm1'

# Version number of this module.
ModuleVersion = '0.1.0'

# Supported PSEditions
# CompatiblePSEditions = @()

# ID used to uniquely identify this module
GUID = '5e04dc01-069b-4fad-a590-ccff2c6e20b5'

# Author of this module
Author = 'jerobins'

# Company or vendor of this module
CompanyName = 'Microsoft'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Fabric Admin Client'

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
RequiredModules = @( @{ ModuleName = 'PSSwaggerUtility'; ModuleVersion = '0.2.0'},
    @{ ModuleName = 'AzureRM.Profile'; ModuleVersion = '3.4.0'} )

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = 
               '.\Generated.PowerShell.Commands\FormatFiles\EdgeGateway.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\EdgeGatewayList.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\EdgeGatewayPool.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\EdgeGatewayPoolList.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\FabricLocationList.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\FileShare.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\FileShareList.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\InfraRole.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\InfraRoleInstance.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\InfraRoleInstanceList.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\InfraRoleInstanceSize.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\InfraRoleList.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\IpPool.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\IpPoolList.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\LogicalNetwork.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\LogicalNetworkList.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\LogicalSubnet.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\LogicalSubnetList.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\MacAddressPool.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\MacAddressPoolList.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\OperationStatus.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\OperationStatusLocation.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\Resource.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\ScaleUnit.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\ScaleUnitCapacity.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\ScaleUnitList.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\ScaleUnitNode.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\ScaleUnitNodeList.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\SlbMuxInstance.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\SlbMuxInstanceList.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\StoragePool.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\StoragePoolList.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\StorageSystem.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\StorageSystemList.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\Volume.ps1xml', 
               '.\Generated.PowerShell.Commands\FormatFiles\VolumeList.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = 'Get-ScaleUnitNode', 'Get-ComputeFabricOperation', 
               'Get-MacAddressPool', 'Invoke-ScaleUnitcaleOut', 
               'Start-ScaleUnitNodeMaintenanceMode', 'Get-LogicalNetwork', 
               'Get-NetworkFabricOperation', 'Get-ScaleUnit', 'Get-EdgeGatewayPool', 
               'Invoke-ScaleUnitNodePowerOn', 'Get-FileShare', 'Get-StoragePool', 
               'Invoke-InfraRoleInstanceShutdown', 'Get-InfraRole', 
               'Stop-ScaleUnitNode', 'Get-FabricLocation', 'Get-StorageSystem', 
               'New-IpPool', 'Get-Volume', 'Invoke-InfraRoleInstanceReboot', 
               'Get-InfraRoleInstance', 'Get-EdgeGateway', 
               'Stop-ScaleUnitNodeMaintenanceMode', 'Invoke-InfraRoleInstancePowerOn', 
               'Invoke-InfraRoleInstancePowerOff', 'Get-IpPool', 
               'Get-SlbMuxInstance', 'Get-LogicalSubnet', 'New-IpPoolObject'

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
        ReleaseNotes = 'Initial release of the Fabric Admin module. Allows administrators view and manage their AzureStack infrastructure.'

        ExternalModuleDependencies = @('PSSwaggerUtility')

    } # End of PSData hashtable

} # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
DefaultCommandPrefix = 'Azs'

}


