# Migration Guide for Az 1.0.0

This document describes the changes between the 6.x versions of AzureRM and Az version 1.0.0

## Table of Contents
- [General breaking changes](#general-breaking-changes)
  - [Windows PowerShell 5.1 and .NET 4.7.2](#windows-powershell-51-and-net-472)
  - [Module Name Changes](#module-name-changes)
  - [Temporary Removal of User Login using PSCredential](#temporary-removal-of-user-login-using-pscredential)
  - [Temporary Device Login instead of Web Browser Control](#temporary-device-login-instead-of-web-browser-control)
- [Breaking changes to Az.Compute (AzureRM.Compute) cmdlets](#breaking-changes-to-azcompute-azurermcompute-cmdlets)
- [Breaking changes to Az.Network (AzureRM.Network) cmdlets](#breaking-changes-to-aznetwork-azurermnetwork-cmdlets)
- [Breaking changes to Az.Resources (AzureRM.Resources) cmdlets](#breaking-changes-to-azresources-azurermresources-cmdlets)
- [Breaking changes to Az.Storage (AzureRM.Storage) cmdlets](#breaking-changes-to-azstorage-azurermstorage-cmdlets)
- [Removed modules](#removed-modules)

## General breaking changes

### Windows PowerShell 5.1 and .NET 4.7.2
- Using Az with Windows PowerShell 5.1 requires the installation of .NET 4.7.2. However, using Az with PowerShell Core does not require .NET 4.7.2. For full details, see our [blog post]().

### Module Name Changes
- `AzureRM.*` -> `Az.*`, except for the following modules:
```
AzureRM.Profile                       -> Az.Accounts
Azure.AnalysisServices                -> Az.AnalysisServices
AzureRM.Consumption                   -> Az.Billing
AzureRM.UsageAggregates               -> Az.Billing
AzureRM.DataFactories                 -> Az.DataFactory
AzureRM.DataFactoryV2                 -> Az.DataFactory
AzureRM.MachineLearningCompute        -> Az.MachineLearning
AzureRM.Insights                      -> Az.Monitor
AzureRM.RecoveryServices.Backup       -> Az.RecoveryServices
AzureRM.RecoveryServices.SiteRecovery -> Az.RecoveryServices
AzureRM.Tags                          -> Az.Resources
Azure.Storage                         -> Az.Storage
```

### Temporary Removal of User Login using PSCredential
- Due to changes in the authenication flow for .NET Standard, we are temporarily removing user login via PSCredential. This will be re-implemented in the near future. For full details, see our [blog post]().

### Temporary Device Login instead of Web Browser Control
- Due to changes in the authenication flow for .NET Standard, we are temporarily using device login as the default login flow during interactive login. Web browser based login will be re-added as the default in the near future, and device login will available via a parameter. For full details, see our [blog post]().

## Breaking changes to Az.Compute (AzureRM.Compute) cmdlets

## Breaking changes to Az.Network (AzureRM.Network) cmdlets

## Breaking changes to Az.Resources (AzureRM.Resources) cmdlets
- Can no longer specify a password when creating a Service Principal Credential

## Breaking changes to Az.Storage (AzureRM.Storage) cmdlets
- The changes include, but not limited to:
### 1. Blob Snapshot
#### Before:
```powershell
$b = Get-AzureStorageBlob -Container $containerName -Blob $blobName -Context $ctx
$b.ICloudBlob.Snapshot()
```

#### After:
```powershell
$b = Get-AzureStorageBlob -Container $containerName -Blob $blobName -Context $ctx
$task = $b.ICloudBlob.SnapshotAsync()
$task.Wait()
$snapshot = $task.Result
```

### 2. Share Snapshot
#### Before:
```powershell
$Share = Get-AzureStorageShare -Name $containerName -Context $ctx
$snapshot = $Share.Snapshot()
```
####  After:
```powershell

$Share = Get-AzureStorageShare -Name $containerName -Context $ctx
$task = $Share.SnapshotAsync()
$task.Wait()
$snapshot = $task.Result
```

### 3. Undelete a soft delete blob
#### Before:
```powershell
$b = Get-AzureStorageBlob -Container $containerName -Blob $blobName -IncludeDeleted -Context $ctx
$b.ICloudBlob.Undelete()
```
#### After:
```powershell
$b = Get-AzureStorageBlob -Container $containerName -Blob $blobName -IncludeDeleted -Context $ctx
$task = $b.ICloudBlob.UndeleteAsync()
$task.Wait()
```

### 4. Set Blob Tier
#### Before:
```powershell
$blockBlob = Get-AzureStorageBlob -Container $containerName -Blob $blockBlobName -Context $ctx
$blockBlob.ICloudBlob.SetStandardBlobTier("hot")

$pageBlob = Get-AzureStorageBlob -Container $containerName -Blob $pageBlobName -Context $ctx
$pageBlob.ICloudBlob.SetPremiumBlobTier("P4")
```

#### After:
```powershell
$blockBlob = Get-AzureStorageBlob -Container $containerName -Blob $blockBlobName -Context $ctx
$task = $blockBlob.ICloudBlob.SetStandardBlobTierAsync("hot")
$task.Wait()

$pageBlob = Get-AzureStorageBlob -Container $containerName -Blob $pageBlobName -Context $ctx
$task = $pageBlob.ICloudBlob.SetPremiumBlobTierAsync("P4")
$task.Wait()
```

## Removed modules
- `AzureRM.Backup`
- `AzureRM.Compute.ManagedService`
- `AzureRM.Scheduler`
- `AzureRM.SiteRecovery`
