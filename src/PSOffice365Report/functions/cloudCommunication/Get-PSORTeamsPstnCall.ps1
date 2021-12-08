function Get-PSORTeamsPstnCall {
    <#
        .SYNOPSIS
        Retrieves PSTN calls between a specified start and end date.

        .DESCRIPTION
        Uses Teams cloud communications Graph API call to retrieve PSTN usage data.
        Requires an Azure application registration with CallRecords.Read.PstnCalls permissions and Graph API access token.

        .OUTPUTS

        .PARAMETER StartDate
        The start date to search for records in YYYY-MM-DD format.

        .PARAMETER EndDate
        The end date to search for records in YYYY-MM-DD format.

        .PARAMETER Days
        The previous number of days to search for records.

        .PARAMETER AccessToken
        An access token for authorization to make Graph API requests.
        Recommended to save this value to a variable for resuse.

        .EXAMPLE
        Get-TeamsPstnCalls -StartDate 2020-03-01 -EndDate 2020-03-31 -AccessToken $accessToken

        This example retrieves PSTN usage records between 2020-03-01 and 2020-03-31 use an access token
        saved to the variable $accessToken.

        .EXAMPLE
        Get-TeamsPstnCalls -Days 7 -AccessToken $accessToken

        This example retrieves PSTN usage records for the previous 7 days using an access token saved
        to the variable $accessToken.

        .LINK
        https://docs.microsoft.com/en-us/graph/api/callrecords-callrecord-getpstncalls

        .NOTES
        The max duration between the StartDate and EndDate is 90 days.
    #>

    [CmdletBinding()]
    param (
        [Parameter(
            Mandatory,
            ParameterSetName = "DateRange",
            HelpMessage = "Start date to search for call records in YYYY-MM-DD format"
        )]
        [string]
        $StartDate,
        [Parameter(
            Mandatory,
            ParameterSetName = "DateRange",
            HelpMessage = "End date to search for call records in YYYY-MM-DD format"
        )]
        [string]
        $EndDate,

        [Parameter(
            Mandatory,
            ParameterSetName = "NumberDays",
            HelpMessage = "The number of days previous to today to search for call records"
        )]
        [ValidateRange(1, 90)]
        [int]
        $Days,
        [Parameter(Mandatory = $false,
            ValueFromPipeline = $false,
            ValueFromPipelineByPropertyName = $false,
            ValueFromRemainingArguments = $false,
            ParameterSetName = 'Filter')]
        [ValidateNotNullOrEmpty()]
        [string]$Filter,
        [Parameter(Mandatory = $false,
            ValueFromPipeline = $false,
            ValueFromPipelineByPropertyName = $false,
            ValueFromRemainingArguments = $false)]
        [switch]$All,
        [Parameter(Mandatory = $false,
            ValueFromPipeline = $false,
            ValueFromPipelineByPropertyName = $false,
            ValueFromRemainingArguments = $false)]
        [ValidateRange(5, 1000)]
        [int]$PageSize
    )
    begin {
        try {
            $url = Join-UriPath -Uri (Get-GraphApiUriPath) -ChildPath 'communications/callRecords'            
            $authorizationToken = Get-PSORAuthorizationToken
            
            #$usageReportFolder = Join-Path -Path (Join-Path -Path $ModuleRoot -ChildPath "internal") -ChildPath 'ortemplate'
            #$usageReportFile = Join-Path -Path $usageReportFolder -ChildPath 'Office365Report_UsageReport_v1.json'
            if (Test-PSFPowerShell -PSMinVersion '7.0.0') {
                #$usageReport = Get-Content -Path $usageReportFile | ConvertFrom-Json -AsHashtable
            }
            else {
                #$usageReport = Get-Content -Path $usageReportFile | ConvertFrom-Json | ConvertTo-HashTable
            }
            #$typeName = '{0}.{1}.{2}' -f $Env:ModuleName, 'callRecords', $Name
        }
        catch {
            Stop-PSFFunction -String 'StringAssemblyError' -StringValues $url -ErrorRecord $_
        }
    }
    process {
        if (Test-PSFFunctionInterrupt) { return }
        #$property = $usageReport[$Name].ResponseProperty
        #$function = $usageReport[$Name].Function
        $function = 'getPstnCalls'    
        $graphApiParameters = @{
            Method             = 'Get'
            AuthorizationToken = 'Bearer {0}' -f $authorizationToken
        }
        
        if ($PSCmdlet.ParameterSetName -eq "DateRange") {            
            $graphApiParameters['Uri'] = Join-UriPath -Uri $url -ChildPath ('{0}(fromDateTime={1},toDateTime={2})' -f $function, $StartDate, $EndDate)
        }
        elseif ($PSCmdlet.ParameterSetName -eq "NumberDays") {
            $today = [datetime]::Today
            $toDateTime = $today.AddDays(1)
            $toDateTimeString = Get-Date -Date $toDateTime -Format yyyy-MM-dd
            $fromDateTime = $today.AddDays( - ($Days - 1))
            $fromDateTimeString = Get-Date -Date $fromDateTime -Format yyyy-MM-dd
            $graphApiParameters['Uri'] = Join-UriPath -Uri $url -ChildPath ('{0}(fromDateTime={1},toDateTime={2})' -f $function, $fromDateTimeString, $toDateTimeString)
        }
        
        if (Test-PSFParameterBinding -Parameter Filter) {
            $graphApiParameters['Filter'] = $Filter
        }

        if (Test-PSFParameterBinding -Parameter All) {
            $graphApiParameters['All'] = $true
        }

        if (Test-PSFParameterBinding -Parameter PageSize) {
            $graphApiParameters['Top'] = $PageSize
        }
        $reportResult = Invoke-GraphApiQuery @graphApiParameters
        $reportResult | Select-PSFObject -Property $property -ExcludeProperty '@odata*'# -TypeName $typeName
    }
    end {}
}