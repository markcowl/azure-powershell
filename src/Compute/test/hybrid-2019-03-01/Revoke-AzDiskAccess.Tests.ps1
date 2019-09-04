$TestRecordingFile = Join-Path $PSScriptRoot 'Revoke-AzDiskAccess.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Revoke-AzDiskAccess' {
    It 'Revoke1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RevokeViaIdentity1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
