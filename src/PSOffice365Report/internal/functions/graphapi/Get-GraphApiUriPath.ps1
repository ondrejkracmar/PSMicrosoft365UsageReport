function Get-GraphApiUriPath
{
    [CmdletBinding(DefaultParametersetName="Uri")]    
    param(
        [Parameter(ParameterSetName="ApiVersion", Mandatory=$false, Position=0)]
        [ValidateSet('v1.0','beta')]
        [string]$GraphApiVersion
    )
    
    if(Test-PSFParameterBinding -ParameterName  GraphApiVersion)
    {
        return Join-UriPath -Uri (Get-PSFConfigValue -FullName PSOffice365Report.Settings.GraphApiUrl) -ChildPath $GraphApiVersion
    }
    else 
    {
        return Join-UriPath -Uri (Get-PSFConfigValue -FullName PSOffice365Report.Settings.GraphApiUrl) -ChildPath (Get-PSFConfigValue -FullName PSOffice365Report.Settings.GraphApiVersion)
    }
}