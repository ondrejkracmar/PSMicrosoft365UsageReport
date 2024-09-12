# Description

Insert a useful description for the Powershell module PSMicrosoft365UsageReport project here.

Remember, it's the first thing a visitor will see.

# Project Setup Instructions
## Working with the layout

- Don't touch the psm1 file
- Place functions you export in `functions/` (can have subfolders)
- Place private/internal functions invisible to the user in `internal/functions` (can have subfolders)
- Don't add code directly to the `postimport.ps1` or `preimport.ps1`.
  Those files are designed to import other files only.
- When adding files & folders, make sure they are covered by either `postimport.ps1` or `preimport.ps1`.
  This adds them to both the import and the build sequence.

## Setting up CI/CD

> To create a PR validation pipeline, set up tasks like this:

- Install Prerequisites (PowerShell Task; VSTS-Prerequisites.ps1)
- Validate (PowerShell Task; VSTS-Validate.ps1)
- Publish Test Results (Publish Test Results; NUnit format; Run no matter what)

> To create a build/publish pipeline, set up tasks like this:

- Install Prerequisites (PowerShell Task; VSTS-Prerequisites.ps1)
- Validate (PowerShell Task; VSTS-Validate.ps1)
- Build (PowerShell Task; VSTS-Build.ps1)
- Publish Test Results (Publish Test Results; NUnit format; Run no matter what)### CSV

If successful, this method returns a `302 Found` response that redirects to a preauthenticated download URL for the report. That URL can be found in the `Location` header in the response.

Preauthenticated download URLs are only valid for a short period of time (a few minutes) and do not require an `Authorization` header.

