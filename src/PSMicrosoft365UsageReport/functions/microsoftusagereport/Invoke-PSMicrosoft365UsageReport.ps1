function Invoke-PSMicrosoft365UsageReport {
    <#
        .SYNOPSIS
            Return data of Microsoft365 Usage report.

        .DESCRIPTION
            Return data of Microsoft365 Usage report.

        .PARAMETER Name
            Name of Microsoft365 Usage Report.

        .PARAMETER Date
            Specific 'Date' in format yyyy-mm-dd.

        .PARAMETER Days
           Last report days (valid values aare 7, 30, 90, 180).

        .EXAMPLE
            PS C:\> Invoke-PSMicrosof365tUsageReport -Name EmailActivityUserDetail -Days 30

            Get details about email activity users have performed in last 30 days.

            PS C:\> Invoke-PSMicrosof365tUsageReport -Name EmailActivityUserDetail -Date 2023-09-23

            Get details about email activity users have performed from 23.9.2023.

    #>
    [OutputType('PSMicrosoft365UsageReport.Report')]
    [CmdletBinding(DefaultParameterSetName = 'UsageReport',
        SupportsShouldProcess = $false,
        PositionalBinding = $true,
        ConfirmImpact = 'Medium')]
    param(
        [Parameter(Mandatory = $True, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $false, ParameterSetName = 'SingleDate')]
        [Parameter(Mandatory = $True, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $false, ParameterSetName = 'NumberDays')]
        [ValidateNotNullOrEmpty()]
        [string]
        $Name,
        [Parameter(Mandatory = $True, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'SingleDate')]
        [string]
        $Date,
        [Parameter(Mandatory = $True, ParameterSetName = 'NumberDays')]
        [ValidateSet(7, 30, 90, 180)]
        [int]
        $Days
    )

    begin {
        $service = Get-PSFConfigValue -FullName ('{0}.Settings.DefaultService' -f $script:ModuleName)
        Assert-EntraConnection -Service $service -Cmdlet $PSCmdlet
        $query = @{
            '$count' = 'true'
            '$top'   = Get-PSFConfigValue -FullName ('{0}.Settings.GraphApiQuery.PageSize' -f $script:ModuleName)
        }
        $templateUsageReportList = Get-PSMicrosoft365UsageReport
        $commandRetryCount = Get-PSFConfigValue -FullName ('{0}.Settings.Command.RetryCount' -f $script:ModuleName)
        $commandRetryWait = New-TimeSpan -Seconds (Get-PSFConfigValue -FullName ('{0}.Settings.Command.RetryWaitInSeconds' -f $script:ModuleName))
    }

    process {
        $usageReport = $templateUsageReportList | Where-Object -Property Name -EQ -Value $Name
        if (-not ([object]::Equals($usageReport, $null))) {
            $query['$format'] = $usageReport.Definition.Format
            switch ($PSCmdlet.ParameterSetName) {
                'NumberDays' {
                    if ($Days -in $usageReport.Definition.Parameters.Days) {
                        $url = Join-UriPath -Uri reports -ChildPath ("{0}(period='D{1}')" -f $usageReport.Definition.Function, $Days)
                    }
                    else {
                        if (Test-PSFPowerShell -PSMinVersion 7.0) {
                            $dayList = ($usageReport.Definition.Parameters.Days | Join-String -SingleQuote -Separator ',')
                        }
                        else {
                            $dayList = ($usageReport.Definition.Parameters.Days | ForEach-Object { "'{0}'" -f $_ }) -join ','
                        }
                        Invoke-TerminatingException -Cmdlet $PSCmdlet -Message ((Get-PSFLocalizedString -Module $script:ModuleName -Name Report.DayFormat.Failed) -f $Days, $dayList)
                    }
                }
                'SingleDate' {
                    if (($Date -match "^(20|21|22)\d\d([- /.])(0[1-9]|1[012])\2(0[1-9]|[12][0-9]|3[01])$") -and (-not([object]::Equals(($Date | Get-Date -ErrorAction SilentlyContinue), $null)))) {
                        $url = Join-UriPath -Uri reports -ChildPath ("{0}(date={1})" -f $usageReport.Definition.Function, $Date)
                    }
                    else {
                        Invoke-TerminatingException -Cmdlet $PSCmdlet -Message ((Get-PSFLocalizedString -Module $script:ModuleName -Name Report.DateFormat.Failed) -f $Date)
                    }
                }
                default {
                    $url = Join-UriPath -Uri reports -ChildPath ("{0}?{1}" -f $usageReport.Definition.Function, $Date)
                }
            }
            switch ($usageReport.Definition.Format) {
                'text/csv' {
                    Invoke-PSFProtectedCommand -ActionString 'Report.Get' -ActionStringValues $Name -Target (Get-PSFLocalizedString -Module $script:ModuleName -Name Report.Platform) -ScriptBlock {
                        Invoke-EntraRequest -Service $service -Path $url -Query $query -Method Get -ErrorAction Stop | ConvertFrom-Csv | ConvertFrom-RestUsageReport -Name $usageReport.Name -ResponseProperty $usageReport.Definition.ResponseProperty
                    } -EnableException $EnableException -PSCmdlet $PSCmdlet -Continue -RetryCount $commandRetryCount -RetryWait $commandRetryWait

                }
                'application/json' {
                    Invoke-PSFProtectedCommand -ActionString 'Report.Get' -ActionStringValues $report -Target (Get-PSFLocalizedString -Module $script:ModuleName -Name Report.Platform) -ScriptBlock {
                        Invoke-EntraRequest -Service $service -Path $url -Query $query -Method Get -ErrorAction Stop #| ConvertFrom-RestUsageReport -Name $usageReport.Name -ResponseProperty $usageReportDefinition.ResponseProperty
                    } -EnableException $EnableException -PSCmdlet $PSCmdlet -Continue -RetryCount $commandRetryCount -RetryWait $commandRetryWait
                }
            }
        }
        else {
            Invoke-TerminatingException -Cmdlet $PSCmdlet -Message ((Get-PSFLocalizedString -Module $script:ModuleName -Name Report.Get.Failed) -f $report)
        }
    }

    end {
    }
}