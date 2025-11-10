function Get-PSMicrosoft365UsageReport {
    <#
	.SYNOPSIS
		Get cached Microsoft 365 usage report definitions.

	.DESCRIPTION
		Retrieves the cached list of Microsoft 365 usage report definitions from the module's internal cache.
		This function is used internally to improve performance by avoiding repeated calls to load report definitions.

		If the cache is not initialized, it will return an empty result.

    .PARAMETER EnableException
        This parameters disables user-friendly warnings and enables the throwing of exceptions. This is less user friendly,
        but allows catching exceptions in calling scripts.

	.EXAMPLE
		PS C:\> Get-PSMicrosoft365UsageReport

		Retrieves all cached Microsoft 365 usage report definitions.

	.NOTES
		This is an internal function used for performance optimization.
		The cache is typically populated when Get-PSMicrosoft365UsageReport is first called.

	#>
    [OutputType('PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport')]
    [CmdletBinding()]
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
        $templateReportFileList = Join-Path -Path (Get-PSFConfigValue -FullName ('{0}.Template.Microsoft365UsageReport.Location' -f 'PSMicrosoft365UsageReport')) -ChildPath $mrTemplate |
        Get-ChildItem -Filter *.json -Recurse
        foreach ($templateReportFile in $templateReportFileList) {
            #[PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport] $usageReport = [PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport]::new()

            # Load the configuration from the JSON file
            [string] $templateReportFilePath = $templateReportFile.FullName

            [bool] $templateReportFileExists = Test-Path -Path $templateReportFilePath -PathType Leaf

            if (-not $templateReportFileExists) {
                # Abort script execution if the configuration file does not exist.
                [string] $message = (Get-PSFLocalizedString -Module $script:ModuleName -Name Report.Get.Failed -f $templateReportFilePath)
                throw [System.IO.FileNotFoundException]::new($message, $templateReportFilePath)
            }
            ConvertFrom-RestUsageReportService -InputObject (Get-Content -Path $templateReportFilePath | ConvertFrom-Json -Depth 5)
        }
    }
    end {}
}