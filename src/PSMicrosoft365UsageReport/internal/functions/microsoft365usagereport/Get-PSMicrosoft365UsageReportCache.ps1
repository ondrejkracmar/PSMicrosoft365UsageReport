function Get-PSMicrosoft365UsageReportCache {
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
		PS C:\> Get-PSMicrosoft365UsageReportCache

		Retrieves all cached Microsoft 365 usage report definitions.

	.NOTES
		This is an internal function used for performance optimization.
		The cache is typically populated when Get-PSMicrosoft365UsageReportCache is first called.

	#>
    [OutputType('PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport')]
    [CmdletBinding()]
    param (
        
    )
    begin {

    }
    process {
        Get-PSFResultCache
    }
    end {
    }
}