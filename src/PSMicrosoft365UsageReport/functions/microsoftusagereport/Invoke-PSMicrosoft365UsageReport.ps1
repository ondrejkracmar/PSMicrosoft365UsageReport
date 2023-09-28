function Invoke-PSMicrosoft365UsageReport {
    <#
        .SYNOPSIS
            Return data of Microsoft365 Usage report.

        .DESCRIPTION
            Return data of Microsoft365 Usage report.

        .PARAMETER Name
            Name of Microsoft365 Usage Report.

        .PARAMETER Type
            Las 'Days' (7, 30, 90, 180) or specific 'Date' in format yyyy-mm-dd.

        .PARAMETER Value
            Based on previous parameter Type, last report days (7, 30, 90, 180) or specific date in format yyyy-mm-dd.

        .EXAMPLE
            PS C:\> Invoke-PSMicrosof365tUsageReport -Name EmailActivityUserDetail -Type Days -Value 30

            Get details about email activity users have performed in last 30 days.

            PS C:\> Invoke-PSMicrosof365tUsageReport -Name EmailActivityUserDetail -Type Date -Value 2023-09-20

            Get details about email activity users have performed from 23.9.203.


    #>
    [OutputType('PSMicrosoft365UsageReport.Report')]
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
        $Type,
        [Parameter(Mandatory = $False, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $false, ParameterSetName = 'UsageReport')]
        [ValidateNotNullOrEmpty()]
        [string]
        $Value
    )

    begin {
        Assert-RestConnection -Service 'graph' -Cmdlet $PSCmdlet
        $query = @{
            '$count' = 'true'
            '$top'   = Get-PSFConfigValue -FullName ('{0}.Settings.GraphApiQuery.PageSize' -f $script:ModuleName)
        }
        $templateUsageReportList = Get-PSMicrosoft365UsageReport
    }

    process {
        foreach ($report in $Name) {
            $usageReport = $templateUsageReportList | Where-Object -Property Name -EQ -Value $report
            $query['$format'] = $usageReport.Definition.Format
            switch ($Type) {
                'Days' {
                    $url = Join-UriPath -Uri reports -ChildPath ("{0}(period='D{1}')" -f $usageReport.Definition.Function, $Value)
                }
                'Date' {
                    $url = Join-UriPath -Uri reports -ChildPath ("{0}(date={1})" -f $usageReport.Definition.Function, $Value)
                }
                default {
                    $url = Join-UriPath -Uri reports -ChildPath ("{0}?{1}" -f $usageReport.Definition.Function, $Value)
                }
            }
            switch ($usageReport.Definition.Format) {
                'text/csv' {
                    Invoke-RestRequest -Service 'graph' -Path $url -Query $query -Method Get | ConvertFrom-Csv | ConvertFrom-RestUsageReport -Name $usageReport.Name -ResponseProperty $usageReport.Definition.ResponseProperty
                }
                'application/json' {
                    Invoke-RestRequest -Service 'graph' -Path $url -Query $query -Method Get #| ConvertFrom-RestUsageReport -Name $usageReport.Name -ResponseProperty $usageReportDefinition.ResponseProperty
                }
            }
        }
    }

    end {
    }
}