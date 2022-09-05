<#
# Example:
Register-PSFTeppArgumentCompleter -Command Get-Alcohol -Parameter Type -Name PSOffice365Reports.alcohol
#>
Register-PSFTeppArgumentCompleter -Command Get-PSMicrosof365tUsageReport -Parameter Name -Name 'microsoft365usagereport.name'

Register-PSFTeppArgumentCompleter -Command Get-PSMicrosof365tUsageReport -Parameter ParameterType -Name 'microsoft365usagereport.name.parametertype'
Register-PSFTeppArgumentCompleter -Command Get-PSMicrosof365tUsageReport -Parameter ParameterValue -Name 'microsoft365usagereport.name.parametervalue'