function ConvertFrom-ResUsageReport {
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
		[hashtabe]$ResponseProperty
	)

	process {
		if ((-not $InputObject) -or ([string]::IsNullOrEmpty($InputObject.id)) ) { return }
		[PSCustomObject]@{
			PSTypeName    = 'PSMicrosoft365Report.UsageReport'
			Id            = $InputObject.id
			SkuId         = $InputObject.skuId
			SkuPartNumber = $InputObject.skuPartNumber
			AppliesTo     = $InputObject.appliesTo
			ConsumedUnits = $InputObject.consumedUnits
			PrepaidUnits  = $InputObject.prepaidUnits
			ServicePlans  = $InputObject.servicePlans
		}
	}
}