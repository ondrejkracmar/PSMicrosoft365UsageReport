function Disconnect-PSOffice365Report {
    [CmdletBinding(DefaultParametersetName = "Token")]    
    param()
    
    process {
        Set-PSFConfig -Module $ENV:ModuleName -Name 'Settings.AuthorizationToken' -Value 'None' -Hidden
    }
}       
