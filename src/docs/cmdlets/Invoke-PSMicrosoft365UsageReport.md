---
external help file: PSMicrosoft365UsageReport-help.xml
Module Name: PSMicrosoft365UsageReport
online version:
schema: 2.0.0
---

# Invoke-PSMicrosoft365UsageReport

## SYNOPSIS
Return data of Microsoft365 Usage report.

## SYNTAX

### UsageReport (Default)
```
Invoke-PSMicrosoft365UsageReport [-ProgressAction <ActionPreference>] [<CommonParameters>]
```

### NumberDays
```
Invoke-PSMicrosoft365UsageReport -Name <String> -Days <Int32> [-ProgressAction <ActionPreference>]
 [<CommonParameters>]
```

### SingleDate
```
Invoke-PSMicrosoft365UsageReport -Name <String> -Date <String> [-ProgressAction <ActionPreference>]
 [<CommonParameters>]
```

## DESCRIPTION
Return data of Microsoft365 Usage report.

## EXAMPLES

### EXAMPLE 1
```
Invoke-PSMicrosof365tUsageReport -Name EmailActivityUserDetail -Days 30
```

Get details about email activity users have performed in last 30 days.

PS C:\\\> Invoke-PSMicrosof365tUsageReport -Name EmailActivityUserDetail -Date 2023-09-23

Get details about email activity users have performed from 23.9.2023.

## PARAMETERS

### -Date
Specific 'Date' in format yyyy-mm-dd.

```yaml
Type: System.String
Parameter Sets: SingleDate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Days
Last report days (valid values aare 7, 30, 90, 180).

```yaml
Type: System.Int32
Parameter Sets: NumberDays
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Name of Microsoft365 Usage Report.

```yaml
Type: System.String
Parameter Sets: NumberDays, SingleDate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### PSMicrosoft365UsageReport.Report
## NOTES

## RELATED LINKS
