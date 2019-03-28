---
external help file: Microsoft.Azure.PowerShell.Cmdlets.Accounts.dll-Help.xml
Module Name: Az.Accounts
online version: https://docs.microsoft.com/en-us/powershell/module/az.accounts/use-azcontext
schema: 2.0.0
---

# Use-AzContext

## SYNOPSIS
Execute a ScriptBlock using the given account and subscription.  The default context for the session is not affected.

## SYNTAX

### Context (Default)
```
Use-AzContext [-ScriptBlock] <ScriptBlock> -Name <String> [-DefaultProfile <IAzureContextContainer>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### Subscription
```
Use-AzContext [-ScriptBlock] <ScriptBlock> [-Subscription <String>] [-Account <String>]
 [-DefaultProfile <IAzureContextContainer>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Execute a ScriptBlock using the given account and subscription.  The default context for the session is not affected.

## EXAMPLES

### Run a ScriptBlock using the selected account and subscription
```powershell
PS C:\> Use-AzContext {Get-AzContext} -Subscription 'Contoso Subscription 1' -Account 'User1@contoso.com'

Name                                     Account                      SubscriptionName             Environment                  TenantId
----                                     -------                      ----------------             -----------                  --------
Contoso Subscription 1                   User1@contoso.com             Contoso Subscription 1       AzureCloud                  xxxxxxxx-xxxx-xxxx-xxxx-...


PS C:\> Get-AzContext

Name                                     Account                      SubscriptionName             Environment                  TenantId
----                                     -------                      ----------------             -----------                  --------
FairWind Subscription 1                  cindy@fairwind.net            FairWind Subscription 1     AzureCloud                   yyyyyyyy-yyyy-yyyy-yyyy-...
```

Execute a ScriptBlock using the chosen account and subscription.  The subscription used elsewhere in the session is unaffected.

## PARAMETERS

### -Account
The account credetials to use.

```yaml
Type: System.String
Parameter Sets: Subscription
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the needed context.

```yaml
Type: System.String
Parameter Sets: Context
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScriptBlock
The script to run under the given context

```yaml
Type: System.Management.Automation.ScriptBlock
Parameter Sets: (All)
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subscription
The subscription to run the script against.

```yaml
Type: System.String
Parameter Sets: Subscription
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### System.Management.Automation.PSObject

## NOTES

## RELATED LINKS
