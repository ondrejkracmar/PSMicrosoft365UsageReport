<#
# Example:
Register-PSFTeppArgumentCompleter -Command Get-Alcohol -Parameter Type -Name PSMicrosoft365UsageReport.alcohol
#>
Register-PSFTeppArgumentCompleter -Command Invoke-PSMicrosoft365UsageReport -Parameter Name -Name 'psmicrosoft365usagereport.name'
Register-PSFTeppArgumentCompleter -Command Invoke-PSMicrosoft365UsageReport -Parameter Days -Name 'psmicrosoft365usagereport.name.days'
Register-PSFTeppArgumentCompleter -Command Invoke-PSMicrosoft365UsageReport -Parameter Date -Name 'psmicrosoft365usagereport.name.date'

Register-PSFTeppArgumentCompleter -Command Get-PSMicrosoft365UsageReport -Parameter Utility -Name 'psmicrosoft365usagereport.utility'
Register-PSFTeppArgumentCompleter -Command Get-PSMicrosoft365UsageReport -Parameter Service -Name 'psmicrosoft365usagereport.service'
Register-PSFTeppArgumentCompleter -Command Get-PSMicrosoft365UsageReport -Parameter Type -Name 'psmicrosoft365usagereport.Type'