function Get-PSMicrosof365tUsageReport {
    [OutputType('PSMicrosoft365Report.UsageReport')]
    [CmdletBinding(DefaultParameterSetName = 'UsageReport',
        SupportsShouldProcess = $false,
        PositionalBinding = $true,
        ConfirmImpact = 'Medium')]
    param(
        [Parameter(Mandatory = $True, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $false, ParameterSetName = 'UsageReport')]
        [ValidateNotNullOrEmpty()]
        [string[]]
        $Name,
        [Parameter(Mandatory = $False, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $false, ParameterSetName = 'UsageReport')]
        [ValidateNotNullOrEmpty()]
        [string]
        $ParameterType,
        [Parameter(Mandatory = $False, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $false, ParameterSetName = 'UsageReport')]
        [ValidateNotNullOrEmpty()]
        [string]
        $ParameterValue,
        [ValidateNotNullOrEmpty()]
        [ValidateRange(1, 999)]
        [int]
        $PageSize = 100
    )

    begin {
        Assert-RestConnection -Service 'graph' -Cmdlet $PSCmdlet
        $query = @{
            '$count' = 'true'
            #    '$top'   = $PageSize
        }
        $templateUsageReportList = Get-PSMicrosoft365ReportTemplate

    }
	
    process {
        
        foreach ($report in $Name) {
            
            $usageReport = $templateUsageReportList | Where-Object -Property Name -EQ -Value $report
            $usageReportDefinition = $usageReport.Definition
            switch ($ParameterType) {
                'Days' {
                    $url = Join-UriPath -Uri reports -ChildPath ("{0}(period='D{1}')" -f $usageReportDefinition.Function, $ParameterValue)
                }
                'Date' {
                    $url = Join-UriPath -Uri reports -ChildPath ("{0}(date={1})" -f $usageReportDefinition.Function, $ParameterValue)
                }
                default{
                    $url = Join-UriPath -Uri reports -ChildPath ("{0}" -f $usageReportDefinition.Function, $ParameterValue)
                }
            }
            Invoke-RestRequest -Service 'graph' -Path $url -Query $query -Method Get | ConvertFrom-Csv | ConvertFrom-RestUsageReport -Name $usageReport.Name -ResponseProperty $usageReportDefinition.ResponseProperty
        }
    }

    end {
    }
}