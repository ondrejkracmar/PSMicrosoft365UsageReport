<#
Registers the cmdlets published by this module.
Necessary for full hybrid module support.
#>
$commonParam = @{
	#HelpFile  = (Resolve-Path "$($script:ModuleRoot)\en-us\PSMicrosoft365UsageReport.dll-Help.xml")
	Module = $ExecutionContext.SessionState.Module
}

Import-PSFCmdlet @commonParam -Name New-PSMicrosoft365UsageReportBatchRequest -Type ([PSMicrosoft365UsageReport.Commands.NewPSMicrosoft365UsageReportBatchRequest])

#Set-Alias -Name Sort-PSFObject -Value Set-PSFObjectOrder -Force -ErrorAction SilentlyContinue