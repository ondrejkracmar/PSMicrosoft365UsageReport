function Initialize-PSORTemplateReport {
    [CmdletBinding()]    
    param()
 
    begin {
        $templateReportList = [System.Collections.ArrayList]::new()
    }
    process {
        $templateReportFileList = Get-PSFConfigValue -FullName ('{0}.Template.Office365.Folder' -f $Env:ModuleName) | Get-ChildItem -Filter *.json -Recurse   
        foreach ($templateReportFile in $templateReportFileList) {
            [hashtable]$templateReport = Get-Content -Path $templateReportFile.FullName | ConvertFrom-Json -Depth 4 -AsHashtable
            $templateReport['Source'] = ([System.IO.Path]::GetDirectoryName($templateReportFile.FullName) | Split-Path -Leaf)
            [void]$templateReportList.Add($templateReport)
        }
        $templateReportList
    }
    end {}
}