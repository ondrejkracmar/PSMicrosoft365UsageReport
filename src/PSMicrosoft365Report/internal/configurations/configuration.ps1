﻿<#
This is an example configuration file

By default, it is enough to have a single one of them,
however if you have enough configuration settings to justify having multiple copies of it,
feel totally free to split them into multiple files.
#>

<#
#>
$Script:ModuleName = 'PSMicrosoft365Report'

Set-PSFConfig -Module $script:ModuleName -Name 'Import.DoDotSource' -Value $false -Initialize -Validation 'bool' -Description "Whether the module files should be dotsourced on import. By default, the files of this module are read as string value and invoked, which is faster but worse on debugging."
Set-PSFConfig -Module $script:ModuleName -Name 'Import.IndividualFiles' -Value $false -Initialize -Validation 'bool' -Description "Whether the module files should be imported individually. During the module build, all module code is compiled into few files, which are imported instead by default. Loading the compiled versions is faster, using the individual files is easier for debugging and testing out adjustments."

Set-PSFConfig -Module $script:ModuleName -Name 'Settings.GraphApiVersion' -Value "v1.0" -Initialize -Validation 'string' -Description "What version of Graph API module is useing."
Set-PSFConfig -Module $script:ModuleName -Name 'Settings.GraphApiUrl' -Value "https://graph.microsoft.com" -Initialize -Validation 'string' -Description "What url of Graph API module is useing."
Set-PSFConfig -Module $script:ModuleName -Name 'Settings.AuthUrl' -Value "https://login.microsoftonline.com" -Initialize -Validation 'string' -Description "What url authentication of Graph Api module is useing."
Set-PSFConfig -Module $script:ModuleName -Name 'Settings.InvokeRestMethodRetryCount' -Value 2 -Initialize -Validation 'integer' -Description "Specifies how many times PowerShell retries a connection when a failure code between 400 and 599, inclusive or 304 is received."
Set-PSFConfig -Module $script:ModuleName -Name 'Settings.InvokeRestMethodRetryTimeSec' -Value 5 -Initialize -Validation 'integer' -Description "Specifies how many times PowerShell retries a connection when a failure code between 400 and 599, inclusive or 304 is received."
Set-PSFConfig -Module $script:ModuleName -Name 'Settings.ContentType' -Value 'application/json' -Initialize -Validation 'string' -Description "Specifies post content type of rest method."
Set-PSFConfig -Module $script:ModuleName -Name 'Settings.AcceptType' -Value 'application/json' -Initialize -Validation 'string' -Description "Specifies header accept type of rest method."
Set-PSFConfig -Module $script:ModuleName -Name 'Settings.AuthorizationToken' -Value '' -Initialize -Validation 'string' -Description "Specifies the last authorization token of Graph Api to Microsoft 365."
Set-PSFConfig -Module $script:ModuleName -Name 'Settings.GraphApiQuery.Format' -Value 'json' -Initialize -Validation 'string' -Description "Specifies the media format of the items returned from Microsoft Graph Api."
Set-PSFConfig -Module $script:ModuleName -Name 'Settings.GraphApiQuery.Query.Level' -Value 'Default' -Initialize -Validation 'string' -Description "Query capabilities level (Default/Advanced). Default value is Default."
Set-PSFConfig -Module $script:ModuleName -Name 'Settings.GraphApiQuery.Query.AdvancedQueryCapabilities.ConsistencyLevel' -Value 'eventual' -Initialize -Validation 'string' -Description "Advanced query capabilities ConsistencyLevel settings."

$m365Report = Join-Path -Path (Join-Path -Path (Join-Path -Path $script:ModuleRoot -ChildPath 'internal') -ChildPath 'mrtemplate') -ChildPath 'Microsoft365UsageReport'
Set-PSFConfig -Module $script:ModuleName -Name 'Template.Microsoft365.Location' -Value $m365Report -Initialize -Validation 'string' -Description "Location of json template of Microsoft 355 Repoort."

