Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.name' -ScriptBlock { (Get-PSMicrosoft365UsageReport | Select-Object -Property Name).Name }
Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.name.date' -ScriptBlock { For ($i = 2; $i -le 27; $i++) { ((Get-Date).AddDays(-$i) | Get-Date -Format 'yyyy-MM-dd').ToString() } }
Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.name.days' -ScriptBlock { @(7, 30, 90, 180) }

Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.utility' -ScriptBlock { (Get-PSMicrosoft365UsageReport | Select-Object -Property Utility -Unique).Utility }
Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.Service' -ScriptBlock { (Get-PSMicrosoft365UsageReport | Select-Object -Property Service -Unique).Service }
Register-PSFTeppScriptblock -Name 'psmicrosoft365usagereport.Type' -ScriptBlock { (Get-PSMicrosoft365UsageReport | Select-Object -Property Type -Unique).Type }