function Get-PSMicrosoft365UsageReportVersion {
    <#
        .SYNOPSIS
            Get version of Microsoft 365 Usage Reports.

        .DESCRIPTION
            Get version of Microsoft 365 Usage Reports.

        .EXAMPLE
            PS C:\> Get-PSMicrosoft365UsageReportVersion

            Get version (string) of Microsoft 365 Usage Reports

    #>
    [OutputType([string])]
    [CmdletBinding()]
    param(
        
    )
    begin {
        
    }
    process {   
        
        switch ((Get-PSFConfig -Module 'PSMicrosoft365UsageReport' -Name 'Settings.DefaultService').value) {
            'PSMicrosoft365UsageReport.Graph' { 'v1.0 '}
            'PSMicrosoft365UsageReport.GraphBeta' { 'beta' }
            Default {
                'v1.0'
            }
        }
    }
    end {}
}