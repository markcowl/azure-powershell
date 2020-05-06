$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-AzPostgreSqlServer.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-AzPostgreSqlServer' {
    It 'CreateExpanded' {
        $password = 'Pa88word!' | ConvertTo-SecureString -AsPlainText -Force
        {
            $password = 'Pa88word!' | ConvertTo-SecureString -AsPlainText -Force
            $server = New-AzPostgreSqlServer -Name $env.serverName2 -ResourceGroupName $env.resourceGroup -Location $env.location -AdministratorUserName pwsh -AdministratorLoginPassword $password -Sku $env.Sku
            Remove-AzPostgreSqlServer -Name $env.serverName2 -ResourceGroupName $env.resourceGroup
        } | Should -Not -Throw
        
    }
}
