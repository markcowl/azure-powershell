# Add-AzureRmAccount

## SYNOPSIS
Adds an authenticated account to use for Azure Resource Manager cmdlet requests.

## DESCRIPTION
The Add-AzureRmAcccount cmdlet adds an authenticated Azure account to use for Azure Resource Manager cmdlet requests.

You can use this authenticated account only with Azure Resource Manager cmdlets.
To add an authenticated account for use with Service Management cmdlets, use the Add-AzureAccount or the Import-AzurePublishSettingsFile cmdlet.

## PARAMETERS

### AccessToken [String]

```powershell
[Parameter(
  Mandatory = $true,
  ParameterSetName = 'Set 1')]
```

The ADAL access token to use to authenticate each ARM request.




### Credential [PSCredential]

```powershell
[Parameter(ParameterSetName = 'Set 2')]
[Parameter(ParameterSetName = 'Set 3')]
```

The Org ID or service principal credentials to use to acquire an ADAL token.



### Environment [AzureEnvironment]

The Azure cloud to target.


### ServicePrincipal [switch]

```powershell
[Parameter(
  Mandatory = $true,
  ParameterSetName = 'Set 3')]
```

Indicates that the provided credentials should be used for authentication as an AD application.



### SubscriptionId [String]

The GUID of the subscription that should be selected as the current subscription.  If SubscriptionId or SubscriptionName are not specified, the first listed subscription will be chosen.


### SubscriptionName [String]

The name of the subscription that should be selected as the default subscription.


### Tenant [String]





## INPUTS
### None


## OUTPUTS

## NOTES


## EXAMPLES
### Example 1: Add an account that requires interactive login

```powershell
PS C:\>Add-AzureRmAccount
Account: azureuser@contoso.com
Environment: AzureCloud
Subscription: xxxx-xxxx-xxxx-xxxx
Tenant: xxxx-xxxx-xxxx-xxxx
```





### Example 2: Add an account that authenticates with organizational ID credentials

```powershell
PS C:\>$Credential = Get-Credential
PS C:\> Add-AzureRmAccount -Credential $Credential
Account: azureuser@contoso.com
Environment: AzureChinaCloud
Subscription: xxxx-xxxx-xxxx-xxxx
Tenant: xxxx-xxxx-xxxx-xxxx
```





### Example3: Add an account that authenticates with service principal credentials

```powershell
PS C:\>$Credential = Get-Credential
PS C:\> Add-AzureRmAccount -Credential $Credential -Tenant "xxxx-xxxx-xxxx-xxxx" -ServicePrincipal
Account: xxxx-xxxx-xxxx-xxxx
Environment: AzureCloud
Subscription: yyyy-yyyy-yyyy-yyyy
Tenant: xxxx-xxxx-xxxx-xxxx
```




### Example 4: Add an account for a specific tenant and subscription

```powershell
PS C:\>Add-AzureRmAccount -Tenant "xxxx-xxxx-xxxx-xxxx" -SubscriptionId "yyyy-yyyy-yyyy-yyyy"
Account: pfuller@contoso.com
Environment: AzureCloud
Subscription: yyyy-yyyy-yyyy-yyyy
Tenant: xxxx-xxxx-xxxx-xxxx
```




## RELATED LINKS

[Set-AzureRmContext]()
[Get-AzureRMContext]()
[Save-AzureRMProfile]()
[Select-AzureRMProfile]()

