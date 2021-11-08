function Get-PSORUsageReport {
    [CmdletBinding(DefaultParameterSetName = 'ReportName',
        SupportsShouldProcess = $false,
        PositionalBinding = $true,
        ConfirmImpact = 'Medium')]
    param(
        [Parameter(Mandatory = $true,
            ValueFromPipeline = $true,
            ValueFromPipelineByPropertyName = $true,
            ValueFromRemainingArguments = $false,
            ParameterSetName = 'Filters')]
        [Parameter(ParameterSetName = 'ReportName')]
        [ValidateNotNullOrEmpty()]
        [ValidateSet("SkypeForBusinessActivityUserDetail"
            , "TeamsUserActivityUserDetail"
            , "EmailActivityUserDetail"
            , "Office365ActiveUserDetail"
            , "Office365ActivationsUserDetail"
            , "EmailAppUsageUserDetail"
            , "MailboxUsageDetail")]
        [string]
        $Name,
        [Parameter(Mandatory = $false,
            ValueFromPipeline = $true,
            ValueFromPipelineByPropertyName = $true,
            ValueFromRemainingArguments = $false,
            ParameterSetName = 'Filters')]
        [Parameter(ParameterSetName = 'ReportName')]
        [ValidateNotNullOrEmpty()]
        [ValidateSet("Period", "Date")]
        [string]
        $ParameterType,
        [Parameter(Mandatory = $false,
            ValueFromPipeline = $true,
            ValueFromPipelineByPropertyName = $true,
            ValueFromRemainingArguments = $false)]
        [ValidateNotNullOrEmpty()]
        [string]
        $ParameterValue,
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
            $url = Join-UriPath -Uri (Get-GraphApiUriPath) -ChildPath "reports"
            $authorizationToken  = Get-PSORAuthorizationToken
            $usageReportFolder = Join-Path -Path (Join-Path -Path $ModuleRoot -ChildPath "internal") -ChildPath 'ortemplate'
            $usageReportFile = Join-Path -Path $usageReportFolder -ChildPath 'Office365Report_UsageReport_v1.json'
            if (Test-PSFPowerShell -PSMinVersion '7.0.0') {
                $usageReport = Get-Content -Path $usageReportFile | ConvertFrom-Json -AsHashtable
            }
            else {
                $usageReport = Get-Content -Path $usageReportFile | ConvertFrom-Json | ConvertTo-HashTable
            }
            $typeName = '{0}.{1}.{2}' -f $Env:ModuleName, 'UsageReport', $Name
        } 
        catch {
            Stop-PSFFunction -String 'StringAssemblyError' -StringValues $url -ErrorRecord $_
        }
    }
	
    process {
        if (Test-PSFFunctionInterrupt) { return }
        $property = $usageReport[$Name].ResponseProperty
        $function = $usageReport[$Name].Function

        $graphApiParameters = @{
            Method             = 'Get'
            AuthorizationToken = 'Bearer {0]' -f $authorizationToken
        }
        if (Test-PSFParameterBinding -Parameter ParameterType, ParameterValue) {
            if ($ParameterType -eq 'Period') {
                $graphApiParameters['Uri'] = Join-UriPath -Uri $url -ChildPath ("{0}(period='{1}'){2}" -f $function, $ParameterValue, '?$format=application/json')
            }
            else {
                $graphApiParameters['Uri'] = Join-UriPath -Uri $url -ChildPath ("{0}(date={1}){2}" -f $function, $ParameterValue, '?$format=application/json')
            }
        }
        else {
            $graphApiParameters['Uri'] = Join-UriPath -Uri $url -ChildPath ("{0}{1}" -f $function, '?$format=application/json')
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
        $reportResult | Select-PSFObject -Property $property -ExcludeProperty '@odata*' -TypeName $typeName

    }

    end {
    }
}