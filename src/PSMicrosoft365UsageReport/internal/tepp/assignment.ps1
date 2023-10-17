<#
# Example:
Register-PSFTeppArgumentCompleter -Command Get-Alcohol -Parameter Type -Name PSMicrosoft365UsageReport.alcohol
#>
Register-PSFTeppArgumentCompleter -Command Invoke-PSMicrosoft365UsageReport -Parameter Name -Name 'psmicrosoft365usagereport.name'

Register-PSFTeppArgumentCompleter -Command Invoke-PSMicrosoft365UsageReport -Parameter Type -Name 'psmicrosoft365usagereport.name.type'
Register-PSFTeppArgumentCompleter -Command Invoke-PSMicrosoft365UsageReport -Parameter Value -Name 'psmicrosoft365usagereport.name.value'