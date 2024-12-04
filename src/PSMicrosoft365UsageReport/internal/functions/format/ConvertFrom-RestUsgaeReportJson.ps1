function ConvertFrom-RestUsgaeReportJson {
	<#
	.SYNOPSIS
		Converts Microsoft 365 Usage report objects to look nice.

	.DESCRIPTION
		Converts Microsoft 365 Usage report objects to look nice.

	.PARAMETER InputObject
		The rest response representing a Microsoft 365 Usage report

	.EXAMPLE
		PS C:\> Invoke-RestRequest -Service 'graph' -Path subscribedSkus -Method Get -ErrorAction Stop | ConvertFrom-RestUsgaeReportJson -ResponseProperty $usageReportDefinition.ResponseProperty
		Retrieves the specified Microsoft 365 Usage report and converts it into something userfriendly
	#>
	[CmdletBinding()]
	param (
		[Parameter(ValueFromPipeline = $true)]
		$InputObject,
		[string[]]$ResponseProperty
	)

	process {
		if (-not $InputObject) { return }

		$outputObject = [ordered]@{}
		foreach ($itemResponseProperty in $ResponseProperty) {
            $lowerCaseProperty = $itemResponseProperty.Substring(0, 1).ToLower() + $itemResponseProperty.Substring(1)
            $outputObject[$itemResponseProperty] =  $InputObject.$lowerCaseProperty
		}
		[PSCustomObject]$outputObject
 }

}