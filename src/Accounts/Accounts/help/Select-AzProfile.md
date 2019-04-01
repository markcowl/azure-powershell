---
external help file: Microsoft.Azure.PowerShell.Cmdlets.Accounts.dll-Help.xml
Module Name: Az.Accounts
online version: https://docs.microsoft.com/en-us/powershell/module/az.accounts/select-azprofile
schema: 2.0.0
---

# Select-AzProfile

## SYNOPSIS
{{Fill in the Synopsis}}

## SYNTAX

```
Select-AzProfile [-Name] <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Select a default profile for modules with multi-profile support.

## EXAMPLES

### Example 1
```powershell
PS C:\> Select-AzProfile hybrid-2019
```

Select the 'hybrid-2019' profile.  This will cause any currently loaded module swith multi-profile support to be reloaded using 
cmdlet exports from the 'nybrid-2019' profile.  All subsequently imported modules will also export cmdlets corresponding with this profile.

## PARAMETERS

### -Name
Name of the profile to select.

```yaml
Type: String
Parameter Sets: (All)
Aliases: ProfileName
Accepted values: hybrid-2019, latest, sample

Required: True
Position: 0
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

### System.Object
## NOTES

## RELATED LINKS
