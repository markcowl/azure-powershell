$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzKeyVaultCertificate.Recording.json'
. (Join-Path $PSScriptRoot '..\generated\runtime' 'HttpPipelineMocking.ps1')

Describe 'Get-AzKeyVaultCertificate' {
    It 'GetDeleted' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ListVersions' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetDeleted1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
