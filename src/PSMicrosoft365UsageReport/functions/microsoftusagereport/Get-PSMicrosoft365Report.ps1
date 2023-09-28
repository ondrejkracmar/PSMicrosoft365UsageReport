function Get-PSMicrosoft365UsageReport {
    <#
        .SYNOPSIS
            Get list of Microsoft 365 Usage Reports.

        .DESCRIPTION
            Get list of Microsoft 365 Usage Reports.

        .EXAMPLE
            PS C:\> Get-PSMicrosoft365UsageReport

            Get list of Microsoft 365 Usage Reports


    #>
    [OutputType('PSMicrosoft365UsageReport.UsageReport.List')]
    [CmdletBinding()]
    param()

    begin {
        $templateReportList = [System.Collections.ArrayList]::new()
    }
    process {
        $templateReportFileList = Join-Path -Path (Get-PSFConfigValue -FullName ('{0}.Template.Microsoft365UsageReport.Location' -f $Script:ModuleName)) -ChildPath ((Get-PSFConfigValue -FullName ('{0}.Settings.GraphApiVersion' -f $Script:ModuleName))) | Get-ChildItem -Filter *.json -Recurse
        foreach ($templateReportFile in $templateReportFileList) {
            $templateReport = Get-Content -Path $templateReportFile.FullName | ConvertFrom-Json
            [void]($templateReportList.Add($templateReport))
        }
        $templateReportList
    }
    end {}
}