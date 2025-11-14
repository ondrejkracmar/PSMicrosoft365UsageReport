function Set-PSMicrosoft365UsageReportService {
    <#
        .SYNOPSIS
            Set version of Microsoft 365 Usage Reports.

        .DESCRIPTION
            Set version of Microsoft 365 Usage Reports.

        .PARAMETER Version
            Version of Microsoft365 Usage Report.

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

        .EXAMPLE
            PS C:\> Set-PSMicrosoft365UsageReportService -Version 'beta'

            Set beta version of Microsoft 365 Usage Reports


    #>
    [OutputType()]
    [CmdletBinding(SupportsShouldProcess = $true)]
    param(
        [ValidateSet('v1.0', 'beta')]
        [string]$Version,
        [switch]$EnableException,
        [switch]$Force
    )
    begin {
        if ($PSCmdlet.MyInvocation.BoundParameters.ContainsKey('Verbose')) {
            [boolean]$cmdLetVerbose = $true
        }
        else{
            [boolean]$cmdLetVerbose =  $false
        }
        if ($Force.IsPresent -and (-not $Confirm.IsPresent)) {
            [bool]$cmdLetConfirm = $false
        }
        else {
            [bool]$cmdLetConfirm = $true
        }
    }
    process {
        Invoke-PSFProtectedCommand -ActionString 'Report.Set' -ActionStringValues $Version -Target (Get-PSFLocalizedString -Module $script:ModuleName -Name Report.Platform) -ScriptBlock {
            if ($Version -eq 'v1.0') {
                Set-PSFConfig -Module $script:ModuleName -Name 'Settings.DefaultService' -Value 'PSMicrosoft365UsageReport.Graph'
            }
            elseif ($Version -eq 'beta') {
                Set-PSFConfig -Module $script:ModuleName -Name 'Settings.DefaultService' -Value 'PSMicrosoft365UsageReport.GraphBeta'
            }
        } -EnableException $EnableException -Confirm:$($cmdLetConfirm) -PSCmdlet $PSCmdlet -Continue
        if (Test-PSFFunctionInterrupt) { return }
    }
    end {}
}