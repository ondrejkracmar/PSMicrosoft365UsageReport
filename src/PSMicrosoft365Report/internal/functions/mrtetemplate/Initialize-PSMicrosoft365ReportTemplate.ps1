function Initialize-PSMicrosoft365ReportTemplate {
    [CmdletBinding()]    
    param()
 
    begin {
        $templateReportList = [System.Collections.ArrayList]::new()
    }
    process {
        $templateReportFileList = Get-PSFConfigValue -FullName ('{0}.Template.Microsoft365.Location' -f $Script:ModuleName) | Get-ChildItem -Filter *.json -Recurse
        foreach ($templateReportFile in $templateReportFileList) {
            $templateReport = Get-Content -Path $templateReportFile.FullName | ConvertFrom-Json            
            [void]$templateReportList.Add($templateReport)
        }
        $templateReportList
    }
    end {}
}