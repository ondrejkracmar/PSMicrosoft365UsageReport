function Invoke-PSMicrosoft365UsageReport {
    <#
        .SYNOPSIS
            Return data of Microsoft365 Usage report.

        .DESCRIPTION
            Return data of Microsoft365 Usage report.

        .PARAMETER Name
            Name of Microsoft365 Usage Report.

        .PARAMETER Format
            Output format text/csv or json.

        .PARAMETER EnableException
            This parameters disables user-friendly warnings and enables the throwing of exceptions. This is less user
            friendly, but allows catching exceptions in calling scripts.

        .PARAMETER WhatIf
            Enables the function to simulate what it will do instead of actually executing.

        .PARAMETER Force
            The Force switch instructs the command to which it is applied to stop processing before any changes are made.
            The command then prompts you to acknowledge each action before it continues.
            When you use the Force switch, you can step through changes to objects to make sure that changes are made only to the specific objects that you want to change.
            This functionality is useful when you apply changes to many objects and want precise control over the operation of the Shell.
            A confirmation prompt is displayed for each object before the Shell modifies the object.

        .PARAMETER Confirm
            The Force switch instructs the command to which it is applied to stop processing before any changes are made.
            The command then prompts you to acknowledge each action before it continues.
            When you use the Force switch, you can step through changes to objects to make sure that changes are made only to the specific objects that you want to change.
            This functionality is useful when you apply changes to many objects and want precise control over the operation of the Shell.
            A confirmation prompt is displayed for each object before the Shell modifies the object.

        .PARAMETER PassThru
            When specified, the cmdlet will not execute the disable license action but will instead
            return a `PSMicrosoftEntraID.Batch.Request` object for batch processing.

        .EXAMPLE
            PS C:\> Invoke-PSMicrosof365UsageReport -Name EmailActivityUserDetail -Days 30

            Get details about email activity users have performed in last 30 days.

            PS C:\> Invoke-PSMicrosof365UsageReport -Name EmailActivityUserDetail -Date 2023-09-23

            Get details about email activity users have performed from 23.9.2023.

            PS C:\> Invoke-PSMicrosof365UsageReport -Name EmailActivityUserDetail -Date 2023-09-23 -force

            Get details about email activity users have performed from 23.9.2023 without question to perform operation.
        #>
    [OutputType('PSMicrosoft365UsageReport.Interface.IReport')]
    [CmdletBinding(DefaultParameterSetName = 'NoParameter',
        SupportsShouldProcess = $true)]
    param(
        [Parameter(Mandatory = $True, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'SingleDate')]
        [Parameter(Mandatory = $True, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'NumberDays')]
        [Parameter(Mandatory = $True, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'NoParameter')]
        [ValidateNotNullOrEmpty()]
        [PsfArgumentCompleter('psmicrosoft365usagereport.name')]
        [string]$Name,
        [Parameter(Mandatory = $True, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'SingleDate')]
        [Parameter(Mandatory = $True, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'NumberDays')]
        [Parameter(Mandatory = $True, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'NoParameter')]
        [PsfArgumentCompleter('psmicrosoft365usagereport.format')]
        [string]$Format,
        [Parameter(Mandatory = $True, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'NumberDays')]
        [PsfArgumentCompleter('psmicrosoft365usagereport.name.days')]
        [string]$Days,
        [Parameter(Mandatory = $True, ValueFromPipeline = $false, ValueFromPipelineByPropertyName = $true, ParameterSetName = 'SingleDate')]
        [PsfArgumentCompleter('psmicrosoft365usagereport.name.date')]
        [string]$Date,
        [Parameter()]
        [switch]$EnableException,
        [Parameter()]
        [switch]$Force,
        [Parameter()]
        [switch]$PassThru
    )
    <#DynamicParam {
        [PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport]$usageReport = Get-PSMicrosoft365UsageReportCache | Where-Object -Property Name -EQ -Value $Name
        If (-not($null -eq $usageReport)) {
            [System.Management.Automation.RuntimeDefinedParameterDictionary]$paramDictionary = New-Object System.Management.Automation.RuntimeDefinedParameterDictionary
            If (-not($null -eq $usageReport.Definition.Parameters.Days)) {
                if (-not($null -eq $usageReport.Definition.Parameters.Days)) {
                    [System.Management.Automation.ParameterAttribute]$daysAttribute = New-Object System.Management.Automation.ParameterAttribute -Property @{
                        Mandatory         = $true
                        ParameterSetName  = 'NumberDays'
                        ValueFromPipeline = $true
                    }
                    # create a validation set
                    [System.Management.Automation.ValidateSetAttribute]$daysParameterValidateSet = New-Object System.Management.Automation.ValidateSetAttribute -ArgumentList @('7', '30', '90', '180')
                    [System.Collections.ObjectModel.Collection[System.Attribute]]$attributeCollection = New-Object System.Collections.ObjectModel.Collection[System.Attribute]
                    [void]$attributeCollection.Add($daysAttribute)
                    [void]$attributeCollection.Add($daysParameterValidateSet)
                    [System.Management.Automation.RuntimeDefinedParameter]$daysParam = New-Object System.Management.Automation.RuntimeDefinedParameter('Days', [String], $attributeCollection)
                    [void]$paramDictionary.Add('Days', $daysParam)
                }
                if (-not($null -eq $usageReport.Definition.Parameters.Date)) {
                    [System.Management.Automation.ParameterAttribute]$dateAttribute = New-Object System.Management.Automation.ParameterAttribute -Property @{
                        Mandatory         = $true
                        ParameterSetName  = 'SingleDate'
                        ValueFromPipeline = $true
                    }
                    # create a validation set
                    [scriptblock]$dateListScriptBlock = { For ($i = 2; $i -le 27; $i++) { ((Get-Date).AddDays(-$i) | Get-Date -Format 'yyyy-MM-dd').ToString() } }
                    [object[]]$dateList = Invoke-Command -ScriptBlock $dateListScriptBlock
                    [System.Management.Automation.ValidateSetAttribute]$dateParameterValidateSet = New-Object System.Management.Automation.ValidateSetAttribute -ArgumentList $dateList
                    [System.Collections.ObjectModel.Collection[System.Attribute]]$attributeCollection = New-Object System.Collections.ObjectModel.Collection[System.Attribute]
                    [void]$attributeCollection.Add($dateAttribute)
                    [void]$attributeCollection.Add($dateParameterValidateSet)
                    [System.Management.Automation.RuntimeDefinedParameter]$dateParam = New-Object System.Management.Automation.RuntimeDefinedParameter('Date', [String], $attributeCollection)
                    [void]$paramDictionary.Add('Date', $dateParam)
                }
            }
            return $paramDictionary
        }
    }#>

    begin {
        Update-PSFTeppCompletion 
        [string]$service = Get-PSFConfigValue -FullName ('{0}.Settings.DefaultService' -f $script:ModuleName)
        Assert-EntraConnection -Service $service -Cmdlet $PSCmdlet
        [hashtable]$query = @{
            '$count' = 'true'
            '$top'   = Get-PSFConfigValue -FullName ('{0}.Settings.GraphApiQuery.PageSize' -f $script:ModuleName)
        }
        [PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport[]]$templateUsageReportList = Get-PSFResultCache
        [int]$commandRetryCount = Get-PSFConfigValue -FullName ('{0}.Settings.Command.RetryCount' -f $script:ModuleName)
        [System.TimeSpan]$commandRetryWait = New-TimeSpan -Seconds (Get-PSFConfigValue -FullName ('{0}.Settings.Command.RetryWaitInSeconds' -f $script:ModuleName))
        if ($Force.IsPresent -and (-not $Confirm.IsPresent)) {
            [bool]$cmdLetConfirm = $false
        }
        else {
            [bool]$cmdLetConfirm = $true
        }
        [string]$defaultFormat = Get-PSFConfigValue -FullName ('{0}.Settings.GraphApiQuery.Format' -f $script:ModuleName)
    }

    process {
        [PSMicrosoft365UsageReport.UsageReport.Microsoft365UsageReport]$usageReport = $templateUsageReportList | Where-Object -Property Name -EQ -Value $Name
        if (-not ([object]::Equals($usageReport, $null))) {
            if (Test-PSFParameterBinding -ParameterName Format) {
                [string]$useFormat = $Format
            }
            else {
                if ($defaultFormat -in $usageReport.Format) {
                    [string]$useFormat = $defaultFormat
                }
                else {
                    [string]$useFormat = @($usageReport.Format)[0]
                }
            }

            $query['$format'] = $useFormat
            switch ($PSCmdlet.ParameterSetName) {
                'NumberDays' {
                    if ($PSBoundParameters.Days -in $usageReport.Definition.Parameters.Days) {
                        [string]$url = Join-UriPath -Uri reports -ChildPath ("{0}(period='D{1}')" -f $usageReport.Definition.Function, $PSBoundParameters.Days)
                    }
                    else {
                        if (Test-PSFPowerShell -PSMinVersion 7.0) {
                            [string]$dayList = ($usageReport.Definition.Parameters.Days | Join-String -SingleQuote -Separator ',')
                        }
                        else {
                            [string]$dayList = ($usageReport.Definition.Parameters.Days | ForEach-Object { "'{0}'" -f $_ }) -join ','
                        }
                        Invoke-TerminatingException -Cmdlet $PSCmdlet -Message ((Get-PSFLocalizedString -Module $script:ModuleName -Name Report.DayFormat.Failed) -f $PSBoundParameters.Days, $dayList)
                    }
                }
                'SingleDate' {
                    if (($PSBoundParameters.Date -match "^(20|21|22)\d\d([- /.])(0[1-9]|1[012])\2(0[1-9]|[12][0-9]|3[01])$") -and (-not([object]::Equals(($PSBoundParameters.Date | Get-Date -ErrorAction SilentlyContinue), $null)))) {
                        [string]$url = Join-UriPath -Uri reports -ChildPath ("{0}(date={1})" -f $usageReport.Definition.Function, $PSBoundParameters.Date)
                    }
                    else {
                        Invoke-TerminatingException -Cmdlet $PSCmdlet -Message ((Get-PSFLocalizedString -Module $script:ModuleName -Name Report.DateFormat.Failed) -f $PSBoundParameters.Date)
                    }
                }
                'NoParameter' {
                    [string]$url = Join-UriPath -Uri reports -ChildPath ("{0}" -f $usageReport.Definition.Function)
                }
            }
            $apiVersion = Get-PSMicrosoft365UsageReportService
            switch ($useFormat) {
                'text/csv' {
                    if ($PassThru.IsPresent) {
                        [hashtable] $header = @{ 'Content-Type' = 'text/csv' }
                        [PSMicrosoft365UsageReport.Batch.Request]@{Headers = $header ; Method = 'GET'; Url = ('/{0}' -f ($url + ('?{0}={1}' -f '$format', $useFormat))) }
                    }
                    else {
                        [hashtable[]] $selectProperties = $usageReport.Definition.ResponseProperty | ForEach-Object {
                            [string] $expression = $_.Expression
                            @{ Name = $_.Name; Expression = [scriptblock]::Create("`$_.'$expression'") }
                        }
                        Invoke-PSFProtectedCommand -ActionString 'Report.Invoke' -ActionStringValues $usageReport.Name -Target (Get-PSFLocalizedString -Module $script:ModuleName -Name Report.Platform) -ScriptBlock {
                            [string] $csvString = (Invoke-EntraRequest -Service $service -Path $url -Query $query -Method Get -ErrorAction Stop)
                            switch ($apiVersion) {
                                'v1.0' {
                                    [string] $updateCsvString = ($csvString -replace "^[ï»¿]+", "" ) 
                                    [pscustomobject[]] $mappedData = $updateCsvString | ConvertFrom-Csv | Select-Object -Property $selectProperties
                                    ConvertFrom-RestUsageReport -ReportName ('PSMicrosoft365UsageReport.Report.{0}' -f $usageReport.Name) -InputObject $mappedData
                                }
                                'beta' {
                                    [pscustomobject[]] $mappedData = $csvString | ConvertFrom-Csv | Select-Object -Property $selectProperties
                                    ConvertFrom-RestUsageReport -ReportName ('PSMicrosoft365UsageReport.Report.Beta.{0}' -f $usageReport.Name) -InputObject $mappedData
                                }
                            }
                        } -EnableException $EnableException -Confirm:$($cmdLetConfirm) -PSCmdlet $PSCmdlet -Continue -RetryCount $commandRetryCount -RetryWait $commandRetryWait
                        if (Test-PSFFunctionInterrupt) { return }
                    }
                }
                'application/json' {
                    if ($PassThru.IsPresent) {
                        [hashtable] $header = @{ 'Content-Type' = 'application/json' }
                        [PSMicrosoft365UsageReport.Batch.Request]@{Headers = $header ; Method = 'GET'; Url = ('/{0}' -f ($url + ('?{0}={1}' -f '$format', $useFormat))) }
                    }
                    else {
                        [hashtable[]] $selectProperties = $usageReport.Definition.ResponseProperty | ForEach-Object {
                            [string] $camelCaseName = $_.Name.Substring(0, 1).ToLower() + $_.Name.Substring(1)
                            @{ Name = $_.Name; Expression = [scriptblock]::Create("`$_.'$camelCaseName'") }
                        }
                        Invoke-PSFProtectedCommand -ActionString 'Report.Invoke' -ActionStringValues $usageReport.Name -Target (Get-PSFLocalizedString -Module $script:ModuleName -Name Report.Platform) -ScriptBlock {
                            [PSCustomObject[]] $jsonResponseObject = Invoke-EntraRequest -Service $service -Path $url -Query $query -Method Get -ErrorAction Stop
                            [PSCustomObject[]]$mappedData = $jsonResponseObject | Select-Object -Property $selectProperties
                            switch ($apiVersion) {
                                'v1.0' {
                                    ConvertFrom-RestUsageReport -ReportName ('PSMicrosoft365UsageReport.Report.{0}' -f $usageReport.Name) -InputObject $mappedData
                                }
                                'beta' {
                                    ConvertFrom-RestUsageReport -ReportName ('PSMicrosoft365UsageReport.Report.Beta.{0}' -f $usageReport.Name) -InputObject $mappedData
                                }
                            }
                        } -EnableException $EnableException -Confirm:$($cmdLetConfirm) -PSCmdlet $PSCmdlet -Continue -RetryCount $commandRetryCount -RetryWait $commandRetryWait
                        if (Test-PSFFunctionInterrupt) { return }
                    }
                }
            }
        }
        else {
            Invoke-TerminatingException -Cmdlet $PSCmdlet -Message ((Get-PSFLocalizedString -Module $script:ModuleName -Name Report.Get.Failed) -f $usageReport.Name)
        }
    }

    end {
    }
}