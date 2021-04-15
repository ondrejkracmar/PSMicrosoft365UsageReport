function Receive-PSORAuthorizationToken
{
    [CmdletBinding(DefaultParametersetName="Token")]    
    param(

            [switch]
            $AuthorizationTokenDetail
        )
 
    process
    {
        try{
            if(Test-PSFParameterBinding -ParameterName AuthorizationTokenDetail)
            {
                $jwtToken = (Get-PSFConfigValue -FullName 'PSOffice365Reports.Settings.AuthorizationToken')  | Get-JWTDetails
                return  $jwtToken                
            }
            else {
                return (Get-PSFConfigValue -FullName 'PSOffice365Reports.Settings.AuthorizationToken')
            }
        }
        catch{
            Stop-PSFFunction -Message "Failed to read authorization token token." -ErrorRecord $_
        }
    }
}