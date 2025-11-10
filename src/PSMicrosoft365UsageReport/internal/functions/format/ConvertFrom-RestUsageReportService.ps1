function ConvertFrom-RestUsageReportService {
    <#
	.SYNOPSIS
		Converts a REST API response object representing a group into a more user-friendly format.

	.DESCRIPTION
		Converts a REST API response object representing a group into a more user-friendly format.

	.PARAMETER InputObject
		The REST API response object that represents a group.

	.DESCRIPTION
		This function takes a REST API response object that represents a group and converts it into a more user-friendly format. This can be useful for displaying group information in a more readable way or for further processing.

	.EXAMPLE
		$report = Get-RestApiReport -Id "reportId"
		$formattedReport = ConvertFrom-RestUsageReportService -InputObject $report
		Write-Output $formattedReport
	#>
    param (
        $InputObject
    )

    if (-not $InputObject) { return }
    $jsonString = $InputObject | ConvertTo-Json -Depth 5

    $type = if ($InputObject -is [array]) {
        [PSMicrosoft365UsageReport.UsageReport.Report[]]
    }
    else {
        [PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport]
    }

    $byteArray = [System.Text.Encoding]::UTF8.GetBytes($jsonString)
    $stream = [System.IO.MemoryStream]::new($byteArray)
    $serializer = [System.Runtime.Serialization.Json.DataContractJsonSerializer]::new($type)
    return $serializer.ReadObject($stream)
}