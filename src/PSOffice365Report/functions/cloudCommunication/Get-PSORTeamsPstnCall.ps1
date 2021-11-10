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
            ParameterSetName="DateRange",
            HelpMessage="Start date to search for call records in YYYY-MM-DD format"
        )]
        [string]
        $StartDate,

        [Parameter(
            Mandatory,
            ParameterSetName="DateRange",
            HelpMessage="End date to search for call records in YYYY-MM-DD format"
        )]
        [string]
        $EndDate,

        [Parameter(
            Mandatory,
            ParameterSetName="NumberDays",
            HelpMessage="The number of days previous to today to search for call records"
        )]
        [ValidateRange(1,90)]
        [int]
        $Days,

        [Parameter(Mandatory, HelpMessage="Access token string for authorization to make Graph API calls")]
        [string]
        $AccessToken
    )

    $headers = @{
        "Authorization" = $AccessToken
    }

    if ($PSCmdlet.ParameterSetName -eq "DateRange") {
        $requestUri = "https://graph.microsoft.com/beta/communications/callRecords/getPstnCalls(fromDateTime=$StartDate,toDateTime=$EndDate)"
    }
    elseif ($PSCmdlet.ParameterSetName -eq "NumberDays") {
        $today = [datetime]::Today
        $toDateTime = $today.AddDays(1)
        $toDateTimeString = Get-Date -Date $toDateTime -Format yyyy-MM-dd
        $fromDateTime = $today.AddDays(-($Days - 1))
        $fromDateTimeString = Get-Date -Date $fromDateTime -Format yyyy-MM-dd

        $requestUri = "https://graph.microsoft.com/beta/communications/callRecords/getPstnCalls(fromDateTime=$fromDateTimeString,toDateTime=$toDateTimeString)"
    }
    
    
    while (-not ([string]::IsNullOrEmpty($requestUri))) {
        try {
            $requestResponse = Invoke-RestMethod -Method GET -Uri $requestUri -Headers $headers -ErrorAction STOP
        }
        catch {
            $_
        }

        $requestResponse.value

        if ($requestResponse.'@odata.NextLink') {
            $requestUri = $requestResponse.'@odata.NextLink'
        }
        else {
            $requestUri = $null
        }
    }
}
