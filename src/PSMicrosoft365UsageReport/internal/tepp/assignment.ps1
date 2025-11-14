<#
# Example:
Register-PSFTeppArgumentCompleter -Command Get-Alcohol -Parameter Type -Name PSMicrosoft365UsageReport.alcohol
#>
Register-PSFTeppArgumentCompleter -Command Invoke-PSMicrosoft365UsageReport -Parameter Name -Name 'psmicrosoft365usagereport.name'
#egister-PSFTeppArgumentCompleter -Command Invoke-PSMicrosoft365UsageReport -Parameter Days -Name 'psmicrosoft365usagereport.name.days'
#egister-PSFTeppArgumentCompleter -Command Invoke-PSMicrosoft365UsageReport -Parameter Date -Name 'psmicrosoft365usagereport.name.date'
#egister-PSFTeppArgumentCompleter -Command Invoke-PSMicrosoft365UsageReport -Parameter Type -Name 'psmicrosoft365usagereport.type'
#egister-PSFTeppArgumentCompleter -Command Invoke-PSMicrosoft365UsageReport -Parameter Format -Name 'psmicrosoft365usagereport.format''