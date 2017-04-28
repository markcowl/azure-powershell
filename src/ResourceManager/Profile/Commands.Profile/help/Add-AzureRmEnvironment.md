# Add-AzureRmEnvironment

## SYNOPSIS
Adds endpoints and metadata for an instance of Azure Resource Manager.

## DESCRIPTION
@{Text=The Add-AzureRmEnvironment cmdlet adds endpoints and metadata to enable Azure Resource Manager cmdlets to connect with a new instance of Azure Resource Manager.
The built-in environments AzureCloud and AzureChinaCloud target existing public instances of Azure Resource Manager.}

## PARAMETERS

### ActiveDirectoryEndpoint [String]

```powershell
[Parameter(
  Position = 6,
  ParameterSetName = 'Set 1')]
```




### ActiveDirectoryServiceEndpointResourceId [String]

```powershell
[Parameter(
  Position = 9,
  ParameterSetName = 'Set 1')]
```




### AdTenant [String]

```powershell
[Parameter(
  Position = 16,
  ParameterSetName = 'Set 1')]
```




### AzureKeyVaultDnsSuffix [String]

```powershell
[Parameter(
  Position = 11,
  ParameterSetName = 'Set 1')]
```




### AzureKeyVaultServiceEndpointResourceId [String]

```powershell
[Parameter(
  Position = 12,
  ParameterSetName = 'Set 1')]
```




### EnableAdfsAuthentication [switch]

```powershell
[Parameter(
  Position = 15,
  ParameterSetName = 'Set 1')]
```




### GalleryEndpoint [String]

```powershell
[Parameter(
  Position = 8,
  ParameterSetName = 'Set 1')]
```




### GraphEndpoint [String]

```powershell
[Parameter(
  Position = 10,
  ParameterSetName = 'Set 1')]
```




### ManagementPortalUrl [String]

```powershell
[Parameter(
  Position = 4,
  ParameterSetName = 'Set 1')]
```




### Name [String]

```powershell
[Parameter(
  Mandatory = $true,
  Position = 1,
  ParameterSetName = 'Set 1')]
```




### PublishSettingsFileUrl [String]

```powershell
[Parameter(
  Position = 2,
  ParameterSetName = 'Set 1')]
```




### ResourceManagerEndpoint [String]

```powershell
[Parameter(
  Position = 7,
  ParameterSetName = 'Set 1')]
```




### ServiceEndpoint [String]

```powershell
[Parameter(
  Position = 3,
  ParameterSetName = 'Set 1')]
```




### SqlDatabaseDnsSuffix [String]

```powershell
[Parameter(
  Position = 14,
  ParameterSetName = 'Set 1')]
```




### StorageEndpoint [String]

```powershell
[Parameter(
  Position = 5,
  ParameterSetName = 'Set 1')]
```




### TrafficManagerDnsSuffix [String]

```powershell
[Parameter(
  Position = 13,
  ParameterSetName = 'Set 1')]
```





## INPUTS
### None


## OUTPUTS

## NOTES


## EXAMPLES
### 1:

```powershell
```




## RELATED LINKS

[Get-AzureRMEnvironment]()

[Remove-AzureRMEnvironment]()

[Set-AzureRMEnvironment]()


