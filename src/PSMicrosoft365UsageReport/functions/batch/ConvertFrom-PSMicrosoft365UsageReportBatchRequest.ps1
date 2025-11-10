function ConvertFrom-PSMicrosoft365UsageReportBatchRequest {
    <#
        .SYNOPSIS
            Converts Microsoft365 Usage Report batch request responses into processed report objects.

        .DESCRIPTION
            This function processes the response data from batch requests created with
            Invoke-PSMicrosoft365UsageReport -PassThru and executed via Invoke-PSMicrosoft365UsageReportBatchRequest.
            It converts the raw response data into properly formatted usage report objects that match
            the output format of direct Invoke-PSMicrosoft365UsageReport calls.

        .PARAMETER InputObject
            The batch response payload object(s) containing both requests and responses from the
            Microsoft Graph $batch endpoint. This should be the output from
            Invoke-PSMicrosoft365UsageReportBatchRequest.

        .PARAMETER EnableException
            This parameters disables user-friendly warnings and enables the throwing of exceptions.
            This is less user friendly, but allows catching exceptions in calling scripts.

        .EXAMPLE
            PS C:\> $requests = Invoke-PSMicrosoft365UsageReport -Name EmailActivityUserDetail -Days 30 -PassThru
            PS C:\> $batchPayload = $requests | New-PSEntraIDBatchRequest
            PS C:\> $batchResponse = $batchPayload | Invoke-PSMicrosoft365UsageReportBatchRequest
            PS C:\> $results = $batchResponse | ConvertFrom-PSMicrosoft365UsageReportBatchRequest

            Creates batch requests for email activity reports, executes them, and converts the responses
            back into formatted report objects.

        .EXAMPLE
            PS C:\> $multipleRequests = @(
            >>     Invoke-PSMicrosoft365UsageReport -Name EmailActivityUserDetail -Days 30 -PassThru
            >>     Invoke-PSMicrosoft365UsageReport -Name TeamsUserActivityUserDetail -Days 30 -PassThru
            >> )
            PS C:\> $batchPayload = $multipleRequests | New-PSEntraIDBatchRequest
            PS C:\> $batchResponse = $batchPayload | Invoke-PSMicrosoft365UsageReportBatchRequest
            PS C:\> $results = $batchResponse | ConvertFrom-PSMicrosoft365UsageReportBatchRequest

            Creates batch requests for multiple usage reports, executes them, and converts all responses.

        .EXAMPLE
            PS C:\> $requests = Invoke-PSMicrosoft365UsageReport -Name EmailActivityUserDetail -Days 30 -PassThru -Format 'text/csv'
            PS C:\> $batchPayload = $requests | New-PSEntraIDBatchRequest
            PS C:\> $batchResponse = $batchPayload | Invoke-PSMicrosoft365UsageReportBatchRequest
            PS C:\> $results = $batchResponse | ConvertFrom-PSMicrosoft365UsageReportBatchRequest

            Creates batch requests for CSV format reports, executes them. Note that CSV responses return redirects
            that need to be manually followed to fetch the actual CSV data.

        .NOTES
            This function correlates batch requests with their responses using the request ID and processes
            the response data according to the original report type and format specified in the request.
    #>
    [OutputType('PSMicrosoft365UsageReport.Batch.UsageReport')]
    [CmdletBinding()]
    param(
        [Parameter(Mandatory = $true, ValueFromPipeline = $true)]
        [PSMicrosoft365UsageReport.Batch.BatchResponsePayload[]]$InputObject,

        [Parameter()]
        [switch]$EnableException
    )

    begin {
        [PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport[]]$templateUsageReportList = Get-PSFResultCache
        [string]$apiVersion = Get-PSMicrosoft365UsageReportService
    }

    process {
        foreach ($batchResponse in $InputObject) {
            for ($i = 0; $i -lt $batchResponse.Requests.Count; $i++) {
                try {
                    [PSMicrosoft365UsageReport.Batch.Request]$request = $batchResponse.Requests[$i]
                    [PSMicrosoft365UsageReport.Batch.Response]$response = $batchResponse.Responses | Where-Object { $_.Id -eq $request.Id }

                    if (-not $response) {
                        Write-PSFMessage -Level Warning -Message "No response found for request ID $($request.Id)"
                        continue
                    }

                    # Extract report function from URL
                    if (-not ($request.Url -match '/reports/([^(]+)')) {
                        Write-PSFMessage -Level Warning -Message "Could not extract report function from URL: $($request.Url)"
                        continue
                    }

                    [string]$reportFunction = $Matches[1]
                    [PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport]$usageReport = $templateUsageReportList |
                    Where-Object { $_.Definition.Function -eq $reportFunction }

                    if (-not $usageReport) {
                        Write-PSFMessage -Level Warning -Message "No usage report definition found for function: $reportFunction"
                        continue
                    }

                    # Create the output object
                    [PSMicrosoft365UsageReport.Batch.UsageReport]$outputReport = [PSMicrosoft365UsageReport.Batch.UsageReport]::new()
                    $outputReport.Utility = $usageReport.Utility
                    $outputReport.Service = $usageReport.Service
                    $outputReport.Type = $usageReport.Type
                    $outputReport.Name = $usageReport.Name

                    # Handle different response statuses
                    if ($response.Status -eq 302) {
                        if ($response.Headers -and $response.Headers.Location) {
                            [string] $csvString = Invoke-RestMethod -Uri $response.Headers.Location -Method Get
                            [hashtable[]] $selectProperties = $usageReport.Definition.ResponseProperty | ForEach-Object {
                                [string] $expression = $_.Expression
                                @{ Name = $_.Name; Expression = [scriptblock]::Create("`$_.'$expression'") }
                            }

                            switch ($apiVersion) {
                                'v1.0' {
                                    [string] $updateCsvString = ($csvString -replace "^[ï»¿]+", "" )
                                    [pscustomobject[]] $mappedData = $updateCsvString | ConvertFrom-Csv | Select-Object -Property $selectProperties
                                    [PSMicrosoft365UsageReport.Interface.IReport[]] $reportData = ConvertFrom-RestUsageReport -ReportName ('PSMicrosoft365UsageReport.Report.{0}' -f $usageReport.Name) -InputObject $mappedData
                                }
                                'beta' {
                                    #[string[]] $lineCsvString = $csvString -split "`n"
                                    #[string] $lineCsvString[0] = ($lineCsvString[0] -replace "ï»¿", "") -replace '\s*,\s*', ',' -replace '\s+', ''
                                    #[string] $updateCsvString = ($lineCsvString -join "`n")
                                    [pscustomobject[]] $mappedData = $csvString | ConvertFrom-Csv | Select-Object -Property $selectProperties
                                    [PSMicrosoft365UsageReport.Interface.IReport[]] $reportData = ConvertFrom-RestUsageReport -ReportName ('PSMicrosoft365UsageReport.Report.Beta.{0}' -f $usageReport.Name) -InputObject $mappedData
                                }
                            }

                            if ($reportData -and $reportData.Count -gt 0) {
                                if ($reportData[0].ReportRefreshDate) {
                                    $outputReport.ReportRefreshDate = [string] $reportData[0].ReportRefreshDate
                                }
                                $outputReport.ReportPeriod = [int] $reportData[0].ReportPeriod
                                $outputReport.Report = $reportData
                            }
                            $outputReport
                        }
                        else {
                            if ($EnableException) {
                                Write-PSFMessage -Level Error -Message "Request ID $($request.Id) returned redirect (302) but no Location header found"
                            }
                        }
                    }
                    elseif ($response.Status -eq 200) {
                        [hashtable[]] $selectProperties = $usageReport.Definition.ResponseProperty | ForEach-Object {
                            [string] $camelCaseName = $_.Name.Substring(0, 1).ToLower() + $_.Name.Substring(1)
                            @{ Name = $_.Name; Expression = [scriptblock]::Create("`$_.'$camelCaseName'") }
                        }

                        [object[]]$mappedData = $response.Body | Select-Object -Property $selectProperties
                        switch ($apiVersion) {
                            'v1.0' {
                                [PSMicrosoft365UsageReport.Interface.IReport[]] $reportData = ConvertFrom-RestUsageReport -ReportName ('PSMicrosoft365UsageReport.Report.{0}' -f $usageReport.Name) -InputObject $mappedData
                            }
                            'beta' {
                                [PSMicrosoft365UsageReport.Interface.IReport[]] $reportData = ConvertFrom-RestUsageReport -ReportName ('PSMicrosoft365UsageReport.Report.Beta.{0}' -f $usageReport.Name) -InputObject $mappedData
                            }
                        }
                        if ($reportData -and $reportData.Count -gt 0) {
                            if ($reportData[0].ReportRefreshDate) {
                                $outputReport.ReportRefreshDate = [string] $reportData[0].ReportRefreshDate
                            }
                            $outputReport.ReportPeriod = $reportData[0].ReportPeriod
                            $outputReport.Report = $reportData
                        }
                        $outputReport
                    }
                    else {
                        [string]$errorMessage = "Unknown error"
                        if ($response.Body -and $response.Body.error -and $response.Body.error.message) {
                            $errorMessage = $response.Body.error.message
                        }
                        elseif ($response.Body) {
                            $errorMessage = $response.Body.ToString()
                        }

                        Write-PSFMessage -Level Error -Message "Request ID $($request.Id) failed with status $($response.Status): $errorMessage"
                        if ($EnableException) {
                            throw "Batch request failed: $errorMessage"
                        }
                    }
                }
                catch {
                    if ($EnableException) {
                        throw
                    }
                    else {
                        Write-PSFMessage -Level Error -Message "Error processing request ID $($request.Id): $($_.Exception.Message)"
                    }
                }
            }
        }
    }

    end {
    }
}