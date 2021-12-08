function Get-PSORAuthorizationToken
{
    [CmdletBinding(DefaultParametersetName="Token")]    
    param()
 
    process
    {
        return (Get-PSFConfig -Module $Env:ModuleName -Name 'Settings.AuthorizationToken' -force).Value
    }
}