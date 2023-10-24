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
        $commandRetryCount = Get-PSFConfigValue -FullName ('{0}.Settings.Command.RetryCount' -f $script:ModuleName)
        $commandRetryWait = New-TimeSpan -Seconds (Get-PSFConfigValue -FullName ('{0}.Settings.Command.RetryWaitIsSeconds' -f $script:ModuleName))
    }

    process {
        foreach ($report in $Name) {
            $usageReport = $templateUsageReportList | Where-Object -Property Name -EQ -Value $report
            if (-not ([object]::Equals($usageReport, $null))) {
                $query['$format'] = $usageReport.Definition.Format
                switch ($Type) {
                    'Days' {
                        if ($Value -in $usageReport.Definition.Parameters.Days) {
                            $url = Join-UriPath -Uri reports -ChildPath ("{0}(period='D{1}')" -f $usageReport.Definition.Function, $Value)
                        }
                        else {
                            if (Test-PSFPowerShell -PSMinVersion 7.0) {
                                $dayList = ($usageReport.Definition.Parameters.Days | Join-String -SingleQuote -Separator ',')
                            }
                            else {
                                $dayList = ($usageReport.Definition.Parameters.Days | ForEach-Object { "'{0}'" -f $_ }) -join ','
                            }
                            Invoke-TerminatingException -Cmdlet $PSCmdlet -Message ((Get-PSFLocalizedString -Module $script:ModuleName -Name Report.DayFormat.Failed) -f $Value, $dayList)
                        }
                    }
                    'Date' {
                        if (($Value -match "^(20|21|22)\d\d([- /.])(0[1-9]|1[012])\2(0[1-9]|[12][0-9]|3[01])$") -and (-not([object]::Equals(($Value | Get-Date -ErrorAction SilentlyContinue), $null)))) {
                            $url = Join-UriPath -Uri reports -ChildPath ("{0}(date={1})" -f $usageReport.Definition.Function, $Value)
                        }
                        else {
                            Invoke-TerminatingException -Cmdlet $PSCmdlet -Message ((Get-PSFLocalizedString -Module $script:ModuleName -Name Report.DateFormat.Failed) -f $Value)
                        }
                    }
                    default {
                        $url = Join-UriPath -Uri reports -ChildPath ("{0}?{1}" -f $usageReport.Definition.Function, $Value)
                    }
                }
                switch ($usageReport.Definition.Format) {
                    'text/csv' {
                        Invoke-PSFProtectedCommand -ActionString 'Report.Get' -ActionStringValues $report -Target (Get-PSFLocalizedString -Module $script:ModuleName -Name Report.Platform) -ScriptBlock {
                            Invoke-RestRequest -Service 'graph' -Path $url -Query $query -Method Get | ConvertFrom-Csv | ConvertFrom-RestUsageReport -Name $usageReport.Name -ResponseProperty $usageReport.Definition.ResponseProperty
                        } -EnableException $EnableException -PSCmdlet $PSCmdlet -Continue -RetryCount $commandRetryCount -RetryWait $commandRetryWait

                    }
                    'application/json' {
                        Invoke-PSFProtectedCommand -ActionString 'Report.Get' -ActionStringValues $report -Target (Get-PSFLocalizedString -Module $script:ModuleName -Name Report.Platform) -ScriptBlock {
                            Invoke-RestRequest -Service 'graph' -Path $url -Query $query -Method Get #| ConvertFrom-RestUsageReport -Name $usageReport.Name -ResponseProperty $usageReportDefinition.ResponseProperty
                        } -EnableException $EnableException -PSCmdlet $PSCmdlet -Continue -RetryCount $commandRetryCount -RetryWait $commandRetryWait

                    }
                }
            }
            else {
                Invoke-TerminatingException -Cmdlet $PSCmdlet -Message ((Get-PSFLocalizedString -Module $script:ModuleName -Name Report.Get.Failed) -f $report)
            }
        }
    }

    end {
    }
}