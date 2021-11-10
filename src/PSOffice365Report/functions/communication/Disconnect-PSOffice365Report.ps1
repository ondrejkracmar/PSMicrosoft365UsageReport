function Disconnect-PSOffice365Report {
    [CmdletBinding(DefaultParametersetName = "Token")]    
    param()
    
    process {
        Set-PSFConfig -Module 'PSOffice365Report' -Name 'Settings.AuthorizationToken' -Value 'None' -Hidden
    }
}       
