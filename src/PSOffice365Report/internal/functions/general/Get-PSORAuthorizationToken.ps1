function Get-PSORAuthorizationToken
{
    [CmdletBinding(DefaultParametersetName="Token")]    
    param()
 
    process
    {
        return (Get-PSFConfig -Module PSOffice365Report -Name 'Settings.AuthorizationToken' -force).Value
    }
}