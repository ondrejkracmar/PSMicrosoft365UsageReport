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

### NoParameter (Default)
```
Invoke-PSMicrosoft365UsageReport -Name <String> [-Format <String>] [-EnableException] [-Force]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### NumberDays
```
Invoke-PSMicrosoft365UsageReport -Name <String> [-Format <String>] [-EnableException] [-Force]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### SingleDate
```
Invoke-PSMicrosoft365UsageReport -Name <String> [-Format <String>] [-EnableException] [-Force]
 [-ProgressAction <ActionPreference>] [-WhatIf] [-Confirm] [<CommonParameters>]
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

PS C:\\\> Invoke-PSMicrosof365tUsageReport -Name EmailActivityUserDetail -Date 2023-09-23 -force

Get details about email activity users have performed from 23.9.2023 without question to perform operation.

## PARAMETERS

### -EnableException
This parameters disables user-friendly warnings and enables the throwing of exceptions.
This is less user
friendly, but allows catching exceptions in calling scripts.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Force
The Force switch instructs the command to which it is applied to stop processing before any changes are made.
The command then prompts you to acknowledge each action before it continues.
When you use the Force switch, you can step through changes to objects to make sure that changes are made only to the specific objects that you want to change.
This functionality is useful when you apply changes to many objects and want precise control over the operation of the Shell.
A confirmation prompt is displayed for each object before the Shell modifies the object.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Format
Output format text/csv or json.

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

### -Name
Name of Microsoft365 Usage Report.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByPropertyName)
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

### -Confirm
The Force switch instructs the command to which it is applied to stop processing before any changes are made.
The command then prompts you to acknowledge each action before it continues.
When you use the Force switch, you can step through changes to objects to make sure that changes are made only to the specific objects that you want to change.
This functionality is useful when you apply changes to many objects and want precise control over the operation of the Shell.
A confirmation prompt is displayed for each object before the Shell modifies the object.

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
Enables the function to simulate what it will do instead of actually executing.

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
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### UsageReport.PSMicrosoft365UsageReport.Report
## NOTES

## RELATED LINKS
