# Get-AzureRmSubscription

## SYNOPSIS
Get subscriptions that the current account can access.

## DESCRIPTION
@{Text=The Get-AzureRmSubscription cmdlet gets the subscription ID, subscription name, and home tenant for subscriptions that the current account can access.}

## PARAMETERS

### All [switch]

```powershell
[Parameter(
  Mandatory = $true,
  ParameterSetName = 'Set 1')]
```




### SubscriptionId [String]

```powershell
[Parameter(ParameterSetName = 'Set 2')]
```




### SubscriptionName [String]

```powershell
[Parameter(ParameterSetName = 'Set 3')]
```




### TenantId [String]

```powershell
[Parameter(ParameterSetName = 'Set 2')]
[Parameter(ParameterSetName = 'Set 3')]
```





## INPUTS
### None


## OUTPUTS

## NOTES


## EXAMPLES
### Example 1: Get all subscriptions in all tenants

```powershell
PS C:\>Get-AzureRmSubscription -All
SubscriptionId: xxxx-xxxx-xxxx-xxxx
TenantId: yyyy-yyyy-yyyy-yyyy
Subscription Name: Contoso Subscription 1
```



### Example 2: Get all subscriptions for a specific tenant

```powershell
PS C:\>Get-AzureRmSubscription -TenantId "xxxx-xxxx-xxxx-xxxx"
SubscriptionId: yyyy-yyyy-yyyy-yyyy
TenantId: xxxx-xxxx-xxxx-xxxx
Subscription Name: Contoso Subscription 1


SubscriptionId: yyyy-yyyy-yyyy-yyyy
TenantId: xxxx-xxxx-xxxx-xxxx
Subscription Name: Contoso Subscription 2
```



### Example 3: Get all subscriptions in the current tenant

```powershell
PS C:\>Get-AzureRmSubscription
SubscriptionId: yyyy-yyyy-yyyy-yyyy
TenantId: xxxx-xxxx-xxxx-xxxx
Subscription Name: Contoso Subscription 1


SubscriptionId: yyyy-yyyy-yyyy-yyyy
TenantId: xxxx-xxxx-xxxx-xxxx
Subscription Name: Contoso Subscription 2
```



### Example 4: Change the current context to use a specific subscription

```powershell
PS C:\>Get-AzureRmSubscription -SubscriptionId "xxxx-xxxx-xxxx-xxxx" -TenantId "yyyy-yyyy-yyyy-yyyy" | Set-AzureRmContext
SubscriptionId: xxxx-xxxx-xxxx-xxxx
TenantId: yyyy-yyyy-yyyy-yyyy
Subscription Name: Contoso Subscription 1
```




## RELATED LINKS


