---
external help file: Microsoft.Azure.PowerShell.Cmdlets.Accounts.dll-Help.xml
Module Name: Az.Accounts
online version: https://docs.microsoft.com/en-us/powershell/module/az.accounts/get-azprofile
schema: 2.0.0
---

# Get-AzProfile

## SYNOPSIS
Gets the profiles available in all modules on the machine, or for specifically selected modules.

## SYNTAX

```
Get-AzProfile [-ModuleName <String[]>] [-ListAvailable] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Gets the available profiles for modules in the curent session and in the PSModulePath

## EXAMPLES

### Example 1
```powershell
PS C:\> Get-AzProfile
hybrid-2019
latest
```

List the available profiles.

## PARAMETERS

### -ListAvailable
Get all the available profiles

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModuleName
If checking for the profile supported in one or more specific modules, the name of the moduels to check.  Named modules must be loaded in the curretn session or in the PSModulePath.

```yaml
Type: String[]
Parameter Sets: (All)
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows changes that would occur if the cmdlet were executed, without making any of these changes.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### System.String

### System.String[]

## NOTES

## RELATED LINKS
