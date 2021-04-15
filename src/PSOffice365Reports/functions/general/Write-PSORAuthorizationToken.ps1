function Write-PSORAuthorizationToken
{
    [CmdletBinding(DefaultParametersetName="Token")]    
    param(
        [Parameter(ParameterSetName="Token", Mandatory=$false, Position=0)]
        [string]$AuthorizationToken)
    
    process {
        try{
            $jwtToken = $AuthorizationToken | Get-JWTDetails     
            Set-PSFConfig -Module 'PSOffice365Reports' -Name 'Settings.AuthorizationToken' -Value $AuthorizationToken
            return $jwtToken
        }
        catch{
            Stop-PSFFunction -Message "Failed to write authorization token token." -ErrorRecord $_
        }
    }
}