<#
# Example:
Register-PSFTeppScriptblock -Name "PSOffice365Reports.alcohol" -ScriptBlock { 'Beer','Mead','Whiskey','Wine','Vodka','Rum (3y)', 'Rum (5y)', 'Rum (7y)' }
#>
Register-PSFTeppScriptblock -Name 'office365usagereport.name' -ScriptBlock { <#(Get-PSAADSubscribedSku | Select-Object -Property SkuId).SkuId #>}
Register-PSFTeppScriptblock -Name 'office365usagereport.period' -ScriptBlock { <#(Get-PSAADSubscribedSku | Select-Object -Property SkuId).SkuId #>}