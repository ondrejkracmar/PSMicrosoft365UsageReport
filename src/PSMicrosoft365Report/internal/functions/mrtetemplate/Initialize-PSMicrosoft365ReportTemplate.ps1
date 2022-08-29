function Initialize-PSMicrosoft365ReportTemplate {
    [CmdletBinding()]    
    param()
 
    begin {
        $templateReportList = [System.Collections.ArrayList]::new()
    }
    process {
        $templateReportFileList = Get-PSFConfigValue -FullName ('{0}.Template.Microsoft365.Location' -f $Script:ModuleName) | Get-ChildItem -Filter *.json -Recurse
        foreach ($templateReportFile in $templateReportFileList) {
            [hashtable]$templateReport = Get-Content -Path $templateReportFile.FullName | ConvertFrom-Json | ConvertTo-PSFHashtable
            $templateReport['Source'] = ($templateReport['Name'])
            [void]$templateReportList.Add($templateReport)
        }
        $templateReportList
    }
    end {}
}