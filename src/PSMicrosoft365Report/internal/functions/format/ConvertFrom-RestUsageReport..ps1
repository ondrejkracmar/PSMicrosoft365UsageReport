function ConvertFrom-RestUsageReport {
	<#
	.SYNOPSIS
		Converts Microsoft 365 Usage report objects to look nice.

	.DESCRIPTION
		Converts Microsoft 365 Usage report objects to look nice.

	.PARAMETER InputObject
		The rest response representing a Microsoft 365 Usage report

	.EXAMPLE
		PS C:\> Invoke-RestRequest -Service 'graph' -Path subscribedSkus -Method Get -ErrorAction Stop | ConvertFrom-ResUsageReport -ResponseProperty $usageReportDefinition.ResponseProperty
		Retrieves the specified Microsoft 365 Usage report and converts it into something userfriendly
	#>
	[CmdletBinding()]
	param (
		[Parameter(ValueFromPipeline = $true)]
		$InputObject,
		[string]$Name,
		[psobject[]]$ResponseProperty
	)

	process {
		if (-not $InputObject) { return }

		$outputObject = [ordered]@{}
		foreach ($itemResponseProperty in $ResponseProperty) {
			$outputObject[$itemResponseProperty.Name] = $InputObject.($itemResponseProperty.Expression)
		}
		$outputObject['PSTypeName'] = ('PSMicrosoft365Report.UsageReport.{0}' -f $Name)
		[PSCustomObject]$outputObject
 }

}