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
        Assert-RestConnection -Service 'graph' -Cmdlet $PSCmdlet
        $query = @{
            '$select' = ((Get-PSFConfig -Module $script:ModuleName -Name Settings.GraphApiQuery.Select.PstnCalls).Value -join ',')
            '$count'  = 'true'
            '$top'    = $PageSize
        }
        $templateReportList = Initialize-PSORTemplateReport | Where-Object -Property Source -EQ -Value (Get-PSFConfigValue -FullName ('{0}.Template.Office365.UsageReport' -f $Env:ModuleName))
    }
	
    process {
        if (Test-PSFFunctionInterrupt) { return }
        $usageReport = $templateReportList | Where-Object -Property Name -EQ -Value $Name
        $responseProperty = $usageReport['Definition']['ResponseProperty']
        $function = $usageReport['Definition']['Function']
        $graphApiParameters = @{
            Method             = 'Get'
            AuthorizationToken = ('Bearer {0}' -f $authorizationToken)
            # Format =  (Get-PSFConfigValue -FullName ('{0}.{1}' -f $Env:ModuleName, 'Settings.ContentType'))
        }
        
        if (Test-PSFParameterBinding -Parameter @('ParameterType', 'ParameterValue')) {
            
            if ($ParameterType -eq 'Period') {
                $graphApiParameters['Uri'] = Join-UriPath -Uri $url -ChildPath ("{0}(period='{1}')" -f $function, $ParameterValue)
            }
            if ($ParameterType -eq 'Date') {
                $graphApiParameters['Uri'] = Join-UriPath -Uri $url -ChildPath ("{0}(date={1})" -f $function, $ParameterValue)
            }
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

        $reportResult = Invoke-GraphApiQuery @graphApiParameters | ConvertFrom-Csv
        $reportResult | Select-PSFObject -Property $responseProperty -ExcludeProperty '@odata*' -TypeName $typeName
    }

    end {
    }
}