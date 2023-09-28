Register-PSFTeppScriptblock -Name 'microsoft365usagereport.name' -ScriptBlock { (Get-PSMicrosoft365UsageReport | Select-Object -Property Name).Name }
Register-PSFTeppScriptblock -Name 'microsoft365usagereport.name.type' -ScriptBlock { ((Get-PSMicrosoft365UsageReport | Where-Object -Property Name -EQ $fakeBoundParameter.Name | Select-Object -ExpandProperty Definition).Parameters | Get-Member -MemberType Properties).Name }
Register-PSFTeppScriptblock -Name 'microsoft365usagereport.name.value' -ScriptBlock {

    Switch ($fakeBoundParameter.Type) {
        'Days' {
            (Get-PSMicrosoft365UsageReport | Where-Object -Property Name -EQ $fakeBoundParameter.Name | Select-Object -ExpandProperty Definition | Select-Object -ExpandProperty Parameters).Days
        }
        'Date' {
            For ($i = 2; $i -le 27; $i++) { ((Get-Date).AddDays(-$i) | Get-Date -Format 'yyyy-MM-dd').ToString() }
        }
    }
}