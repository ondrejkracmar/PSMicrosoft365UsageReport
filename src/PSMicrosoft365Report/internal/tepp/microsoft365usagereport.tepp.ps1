Register-PSFTeppScriptblock -Name 'microsoft365usagereport.name' -ScriptBlock { (Get-PSMicrosoft365ReportTemplate | Select-Object -Property Name).Name }
Register-PSFTeppScriptblock -Name 'microsoft365usagereport.name.parametertype' -ScriptBlock { ((Get-PSMicrosoft365ReportTemplate | Where-Object -Property Name -EQ $fakeBoundParameter.Name | Select-Object -ExpandProperty Definition).Parameters | Get-Member -MemberType Properties).Name }
Register-PSFTeppScriptblock -Name 'microsoft365usagereport.name.parametervalue' -ScriptBlock {
    
    Switch ($fakeBoundParameter.ParameterType) {
        'Days' {
            (Get-PSMicrosoft365ReportTemplate | Where-Object -Property Name -EQ $fakeBoundParameter.Name | Select-Object -ExpandProperty Definition | Select-Object -ExpandProperty Parameters).Days
        }
        'Date' {
            For ($i = 1; $i -le 27; $i++) { ((Get-Date).AddDays(-$i) | Get-Date -Format 'yyyy-MM-dd').ToString() } 
        }
    }
}