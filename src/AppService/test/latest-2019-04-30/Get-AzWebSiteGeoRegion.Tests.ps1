$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzWebSiteGeoRegion.Recording.json'
. (Join-Path $PSScriptRoot '..\generated\runtime' 'HttpPipelineMocking.ps1')

Describe 'Get-AzWebSiteGeoRegion' {
    It 'List1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
