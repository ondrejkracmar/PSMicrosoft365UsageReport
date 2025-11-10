
Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.name' -ScriptBlock {
    [PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport[]] $usageReportList = Get-PSFResultCache
    foreach ($usageReport in $usageReportList) {
        @{ Text = $usageReport.Name; ToolTip = $usageReport.Description }
    } 
} -AutoTraining
#Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.name.date' -ScriptBlock { For ($i = 2; $i -le 27; $i++) { ((Get-Date).AddDays(-$i) | Get-Date -Format 'yyyy-MM-dd').ToString() } }
#Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.name.days' -ScriptBlock { @(7, 30, 90, 180) }

#Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.utility' -ScriptBlock { (Get-PSMicrosoft365UsageReport | Select-Object -Property Utility -Unique).Utility }
#Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.Service' -ScriptBlock { (Get-PSMicrosoft365UsageReport | Select-Object -Property Service -Unique).Service }
#Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.type' -ScriptBlock { (Get-PSMicrosoft365UsageReport | Select-Object -Property Type -Unique).type }
#Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.format' -ScriptBlock { (Get-PSMicrosoft365UsageReport | Where-Object -Property Name -Value $fakeBoundParameter.Name -EQ).Format }
