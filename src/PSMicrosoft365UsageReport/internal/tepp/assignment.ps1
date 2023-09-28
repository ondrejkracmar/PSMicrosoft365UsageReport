<#
# Example:
Register-PSFTeppArgumentCompleter -Command Get-Alcohol -Parameter Type -Name PSMicrosoft365UsageReport.alcohol
#>
Register-PSFTeppArgumentCompleter -Command Invoke-PSMicrosof365tUsageReport -Parameter Name -Name 'microsoft365usagereport.name'

Register-PSFTeppArgumentCompleter -Command Invoke-PSMicrosof365tUsageReport -Parameter Type -Name 'microsoft365usagereport.name.type'
Register-PSFTeppArgumentCompleter -Command Invoke-PSMicrosof365tUsageReport -Parameter Value -Name 'microsoft365usagereport.name.value'