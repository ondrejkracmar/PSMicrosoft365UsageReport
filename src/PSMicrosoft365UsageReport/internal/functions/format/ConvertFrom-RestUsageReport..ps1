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
	param (
		[string]$ReportName,
		$InputObject
	)
	if (-not $InputObject) { return }
	$jsonString = ($InputObject | ConvertTo-Json -Depth 3) -replace '""', 'null'
	if ($InputObject -is [array]) {
		[byte[]] $byteArray = [System.Text.Encoding]::UTF8.GetBytes($jsonString)
		[System.IO.MemoryStream] $stream = [System.IO.MemoryStream]::new($byteArray)
		$scriptBlock = [scriptblock]::Create("[System.Runtime.Serialization.Json.DataContractJsonSerializer]::new([$ReportName[]])")
		[System.Runtime.Serialization.Json.DataContractJsonSerializer] $serializer = Invoke-Command -ScriptBlock $scriptBlock
	}
	else {
		[byte[]] $byteArray = [System.Text.Encoding]::UTF8.GetBytes($jsonString)
		[System.IO.MemoryStream] $stream = [System.IO.MemoryStream]::new($byteArray)
		$scriptBlock = [scriptblock]::Create("[System.Runtime.Serialization.Json.DataContractJsonSerializer]::new([$ReportName])")
		[System.Runtime.Serialization.Json.DataContractJsonSerializer] $serializer = Invoke-Command -ScriptBlock $scriptBlock
	}
	return	$serializer.ReadObject($stream)
}