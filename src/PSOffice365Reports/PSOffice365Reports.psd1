﻿@{
	# Script module or binary module file associated with this manifest
	RootModule = 'PSOffice365Reports.psm1'
	
	# Version number of this module.
	ModuleVersion = '1.0.3'
	
	# ID used to uniquely identify this module
	GUID = '2e6e0ced-59d5-4168-b7b8-677ee3dd22cc'
	
	# Author of this module
	Author = 'Ondrej Kracmar'
	
	# Company or vendor of this module
	CompanyName = 'Ondrej Kracmar'
	
	# Copyright statement for this module
	Copyright = 'Copyright (c) 2021 Ondrej Kracmar'
	
	# Description of the functionality provided by this module
	Description = 'Office 365 Reports via Graph API'
	
	# Minimum version of the Windows PowerShell engine required by this module
	PowerShellVersion = '5.0'
	
	# Modules that must be imported into the global environment prior to importing
	# this module
	RequiredModules = @(
		@{ ModuleName='PSFramework'; ModuleVersion='1.6.198' }
	)
	
	# Assemblies that must be loaded prior to importing this module
	# RequiredAssemblies = @('bin\PSOffice365Reports.dll')
	
	# Type files (.ps1xml) to be loaded when importing this module
	# TypesToProcess = @('xml\PSOffice365Reports.Types.ps1xml')
	
	# Format files (.ps1xml) to be loaded when importing this module
	# FormatsToProcess = @('xml\PSOffice365Reports.Format.ps1xml')
	
	# Functions to export from this module
	FunctionsToExport = @(
		"Get-PSORRequestStatus",
		'Receive-PSORAuthorizationToken',
		'Write-PSORAuthorizationToken',
		'Get-PSORUsageReport'
	)
	
	# Cmdlets to export from this module
	CmdletsToExport = ''
	
	# Variables to export from this module
	VariablesToExport = ''
	
	# Aliases to export from this module
	AliasesToExport = ''
	
	# List of all modules packaged with this module
	ModuleList = @()
	
	# List of all files packaged with this module
	FileList = @()
	
	# Private data to pass to the module specified in ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
	PrivateData = @{
		
		#Support for PowerShellGet galleries.
		PSData = @{
			
			# Tags applied to this module. These help with module discovery in online galleries.
			# Tags = @()
			
			# A URL to the license for this module.
			# LicenseUri = ''
			
			# A URL to the main website for this project.
			# ProjectUri = ''
			
			# A URL to an icon representing this module.
			# IconUri = ''
			
			# ReleaseNotes of this module
			# ReleaseNotes = ''
			
		} # End of PSData hashtable
		
	} # End of PrivateData hashtable
}