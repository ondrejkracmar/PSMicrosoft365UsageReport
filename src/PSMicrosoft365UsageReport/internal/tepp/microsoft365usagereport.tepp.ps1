
Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.name' -ScriptBlock {
    [PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport[]] $usageReportList = Get-PSFResultCache
    foreach ($usageReport in $usageReportList) {
        @{ Text = $usageReport.Name; ToolTip = $usageReport.Description }
    }
} -AutoTraining
Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.name.date' -ScriptBlock {
    # Generate available report dates (2 to 27 days ago)
    for ($i = 2; $i -le 27; $i++) {
        $date = (Get-Date).AddDays(-$i)
        @{ Text = $date.ToString('yyyy-MM-dd'); ToolTip = $date.ToString('dddd, MMMM dd, yyyy') }
    }
} -AutoTraining

Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.name.days' -ScriptBlock {
    @{ Text = 7; ToolTip = 'Previous 7 days' }, @{ Text = 30; ToolTip = 'Previous 30 days' }, @{ Text = 90; ToolTip = 'Previous 90 days' }, @{ Text = 180; ToolTip = 'Previous 180 days' }

} -AutoTraining

Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.format' -ScriptBlock {
    @{ Text = 'text/csv'; ToolTip = 'CSV format - Comma-separated values' }
    @{ Text = 'application/json'; ToolTip = 'JSON format - JavaScript Object Notation' }
} -AutoTraining

#Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.utility' -ScriptBlock { (Get-PSMicrosoft365UsageReport | Select-Object -Property Utility -Unique).Utility }
#Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.Service' -ScriptBlock { (Get-PSMicrosoft365UsageReport | Select-Object -Property Service -Unique).Service }
#Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.type' -ScriptBlock { (Get-PSMicrosoft365UsageReport | Select-Object -Property Type -Unique).type }
#Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.format' -ScriptBlock { (Get-PSMicrosoft365UsageReport | Where-Object -Property Name -Value $fakeBoundParameter.Name -EQ).Format }
