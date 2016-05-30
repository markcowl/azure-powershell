@{
RootModule = 'UpdateExports.psm1'
ModuleVersion = '1.0.0.0'
Author = 'Microsoft Corporation'
CompanyName = 'Microsoft Corporation'
Copyright = '© Microsoft Corporation. All rights reserved.'
PowerShellVersion = '3.0'
FunctionsToExport = @('Test-AllModuleExports', 
                    'Update-AllModuleExports', 
                    'Update-ModuleExports',
                    'Test-ModuleExports'
)
VariablesToExport = "*"

FileList = @('UpdateExports.psm1')
RequiredModules = @( @{ ModuleName = 'PowerShellGet'; ModuleVersion = '1.0.0.6'})
PrivateData = @{}
}


