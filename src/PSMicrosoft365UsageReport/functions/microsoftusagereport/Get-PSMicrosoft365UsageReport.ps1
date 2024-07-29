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
    [OutputType([System.Collections.ArrayList])]
    [CmdletBinding()]
    param()

    begin {
        $service = Get-PSFConfigValue -FullName ('{0}.Settings.DefaultService' -f $script:ModuleName)
        $templateReportList = [System.Collections.ArrayList]::new()
    }
    process {
        if ($service -eq 'PSMicrosoft365UsageReport.Graph') {
            $mrTemplate = 'v1.0'
        }
        else {
            $mrTemplate = 'beta'
        }
        $templateReportFileList = Join-Path -Path (Get-PSFConfigValue -FullName ('{0}.Template.Microsoft365UsageReport.Location' -f $Script:ModuleName)) -ChildPath $mrTemplate | Get-ChildItem -Filter *.json -Recurse
        foreach ($templateReportFile in $templateReportFileList) {
            $templateReport = Get-Content -Path $templateReportFile.FullName | ConvertFrom-Json
            [void]($templateReportList.Add($templateReport))
        }
        $templateReportList
    }
    end {}
}