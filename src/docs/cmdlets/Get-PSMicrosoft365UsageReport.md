---
external help file: PSMicrosoft365UsageReport-help.xml
Module Name: PSMicrosoft365UsageReport
online version:
schema: 2.0.0
---

# Get-PSMicrosoft365UsageReport

## SYNOPSIS
Get list of Microsoft 365 Usage Reports.

## SYNTAX

```
Get-PSMicrosoft365UsageReport [-Utility <String>] [-Service <String>] [-Type <String>]
 [-ProgressAction <ActionPreference>] [<CommonParameters>]
```

## DESCRIPTION
Get list of Microsoft 365 Usage Reports.

## EXAMPLES

### EXAMPLE 1
```
Get-PSMicrosoft365UsageReport
```

Get list of Microsoft 365 Usage Reports

### EXAMPLE 2
```
Get-PSMicrosoft365UsageReport -Service Teams -Type User
```

Get list of Microsoft 365 Usage Teams Reports with user's details

## PARAMETERS

### -ProgressAction
{{ Fill ProgressAction Description }}

```yaml
Type: System.Management.Automation.ActionPreference
Parameter Sets: (All)
Aliases: proga

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Service
Get list of Microsoft365 Usage Report with selected service name.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type
Get list of Microsoft365 Usage Report with selected type name.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Utility
Get list of Microsoft365 Usage Report with seledcted utility name.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### UsageReport.Microsoft365UsageReport
## NOTES

## RELATED LINKS
