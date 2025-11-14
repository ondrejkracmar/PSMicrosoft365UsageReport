try {
    if ($PSVersionTable.PSVersion.Major -ge 5) {
        Add-Type -Path "$script:ModuleRoot\bin\PSMicrosoft365UsageReport.dll" -ErrorAction Stop
    }
    else {
        Add-Type -Path "$script:ModuleRoot\bin\PS4\PSMicrosoft365UsageReport.dll" -ErrorAction Stop
    }
}
catch {
    Write-Warning "Failed to load PSMicrosoft365UsageReport Assembly! Unable to import module."
    throw
}
try {
    Update-TypeData -AppendPath "$script:ModuleRoot\types\PSMicrosoft365UsageReport.Types.ps1xml" -ErrorAction Stop
}
catch {
    Write-Warning "Failed to load PSMicrosoft365UsageReport type extensions! Unable to import module."
    throw
}