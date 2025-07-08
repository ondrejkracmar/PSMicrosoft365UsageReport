function Get-PSMicrosoft365UsageReport {
    <#
        .SYNOPSIS
            Get list of Microsoft 365 Usage Reports.

        .DESCRIPTION
            Get list of Microsoft 365 Usage Reports.

        .PARAMETER Utility
            Get list of Microsoft365 Usage Report with seledcted utility name.

        .PARAMETER Service
            Get list of Microsoft365 Usage Report with selected service name.

        .PARAMETER Type
            Get list of Microsoft365 Usage Report with selected type name.

        .EXAMPLE
            PS C:\> Get-PSMicrosoft365UsageReport

            Get list of Microsoft 365 Usage Reports

        .EXAMPLE
            PS C:\> Get-PSMicrosoft365UsageReport -Service Teams -Type User

            Get list of Microsoft 365 Usage Teams Reports with user's details

    #>
    [OutputType([PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport])]
    [CmdletBinding(DefaultParameterSetName = 'FilterReport')]
    param(
        [Parameter(Mandatory = $false, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $false, ParameterSetName = 'FilterReport')]
        [ValidateNotNullOrEmpty()]
        [string]$Utility,
        [Parameter(Mandatory = $false, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $false, ParameterSetName = 'FilterReport')]
        [ValidateNotNullOrEmpty()]
        [string]$Service,
        [Parameter(Mandatory = $false, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $false, ParameterSetName = 'FilterReport')]
        [ValidateNotNullOrEmpty()]
        [string]$Type
    )
    begin {
        [string]$apiService = Get-PSFConfigValue -FullName ('{0}.Settings.DefaultService' -f $script:ModuleName)
        $criteria = @{}
        if (Test-PSFParameterBinding -ParameterName Utility) {
            $criteria['Utility'] = $Utility
        }
        if (Test-PSFParameterBinding -ParameterName Service) {
            $criteria['Service'] = $Service
        }
        if (Test-PSFParameterBinding -ParameterName Type) {
            $criteria['Type'] = $Type
        }
    }
    process {
        if ($apiService -eq 'PSMicrosoft365UsageReport.Graph') {
            [string]$mrTemplate = 'v1.0'
        }
        elseif ($apiService -eq 'PSMicrosoft365UsageReport.GraphBeta') {
            [string]$mrTemplate = 'beta'
        }
        $templateReportFileList = Join-Path -Path (Get-PSFConfigValue -FullName ('{0}.Template.Microsoft365UsageReport.Location' -f $Script:ModuleName)) -ChildPath $mrTemplate |
        Get-ChildItem -Filter *.json -Recurse
        foreach ($templateReportFile in $templateReportFileList) {
            [PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport] $usageReport = [PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport]::new()

            # Load the configuration from the JSON file
            [string] $templateReportFilePath = $templateReportFile.FullName

            [bool] $templateReportFileExists = Test-Path -Path $templateReportFilePath -PathType Leaf

            if (-not $templateReportFileExists) {
                # Abort script execution if the configuration file does not exist.
                [string] $message = (Get-PSFLocalizedString -Module $script:ModuleName -Name Report.Get.Failed -f $templateReportFilePath)
                throw [System.IO.FileNotFoundException]::new($message, $templateReportFilePath)
            }

            [System.Runtime.Serialization.Json.DataContractJsonSerializer] $serializer = [System.Runtime.Serialization.Json.DataContractJsonSerializer]::new([PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport])
            [System.IO.FileStream] $stream = [System.IO.File]::Open($templateReportFilePath, [System.IO.FileMode]::Open)
            try {
                $usageReport = $serializer.ReadObject($stream)
            }
            catch {
                # Do not continue if there is any issue reading the configuration file
                throw
            }
            finally {
                $stream.Close()
            }
            Get-FilterObject -InputObject $usageReport -Criteria $criteria
        }
    }

    end {}
}