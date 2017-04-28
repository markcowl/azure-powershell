# Set-AzureRMContext

## SYNOPSIS
Sets the tenant, subscription, and environment for cmdlets to use in the current session.

## DESCRIPTION
@{Text=The Set-AzureRmContext cmdlet sets authentication information for cmdlets that you run in the current session.
The context includes tenant, subscription, and environment information.}

## PARAMETERS

### Subscription [AzureSubscription]

```powershell
[Parameter(
  Mandatory = $true,
  ParameterSetName = 'Set 1')]
```




### SubscriptionId [String]

```powershell
[Parameter(
  Mandatory = $true,
  ParameterSetName = 'Set 2')]
[Parameter(
  Mandatory = $true,
  ParameterSetName = 'Set 3')]
```




### Tenant [AzureTenant]

```powershell
[Parameter(ParameterSetName = 'Set 1')]
```




### TenantId [String]

```powershell
[Parameter(ParameterSetName = 'Set 2')]
[Parameter(ParameterSetName = 'Set 4')]
```





## INPUTS
### None


## OUTPUTS

## NOTES


## EXAMPLES
### Example1: Set the subscription context

```powershell
PS C:\>Set-AzureRmContext -SubscriptionId "xxxx-xxxx-xxxx-xxxx"
Account: PFuller@contoso.com

Environment: AzureCloud

Subscription: xxxx-xxxx-xxxx-xxxx

Tenant: yyyy-yyyy-yyyy-yyyy
```




## RELATED LINKS

[Get-AzureRMContext]()


