Function Invoke-PSMicrosoft365UsageReportBatchRequest {
    <#
    .SYNOPSIS
        Invokes a Microsoft Graph batch request using an array of BatchRequestPayload objects,
        then returns a combined object with both .requests and .responses.

    .DESCRIPTION
        This function expects pipeline input of BatchRequestPayload objects
        (such as those produced by New-PSEntraIDBatchRequest).
        Each BatchRequestPayload contains up to 20 sub-requests (ID=1..20).

        For each batch payload, this function can validate the requests (Test-PSMicrosoft365UsageReportBatchRequest),
        then send them to the Graph $batch endpoint (via Invoke-EntraRequest).
        It captures the Graph response (which typically has a "responses" array)
        and outputs a combined [pscustomobject] with:
           .requests   = the sub-requests
           .responses  = the sub-responses from Graph

        This allows a subsequent cmdlet (e.g. Invoke-PSMicrosoft365UsageReportBatchResponse) to correlate them by id.

    .PARAMETER InputObject
        An array of BatchRequestPayload objects to be processed. Each object
        has a .Requests list containing up to 20 Request objects.

    .PARAMETER EnableException
        This parameter disables user-friendly warnings and enables the throwing of exceptions.
        Less user friendly, but allows catching exceptions in calling scripts.

    .PARAMETER Force
        The Force switch instructs the command to stop processing before any changes are made
        and prompt for confirmation (depending on your logic in the code).
        When used, you can step through changes to ensure only specific objects are modified.

    .PARAMETER WhatIf
        Enables the function to simulate what it will do instead of actually executing.

    .PARAMETER Confirm
        The Confirm switch instructs the command to stop processing before any changes are made.
        The command then prompts you to acknowledge each action before it continues.
        This functionality is useful when you apply changes to many objects
        and want precise control over the operation of the Shell.

    .EXAMPLE
        # Suppose $payloads are returned from New-PSEntraIDBatchRequest -InputObject $requests
        $payloads = New-PSEntraIDBatchRequest -InputObject $requests

        # Then call:
        $result = $payloads | Invoke-PSMicrosoft365UsageReportBatchRequest -EnableException -WhatIf -Force

        # $result now is an array of objects with .requests and .responses,
        # ready to be analyzed by a separate cmdlet that correlates them.

    #>
    [Diagnostics.CodeAnalysis.SuppressMessageAttribute('PSUseShouldProcessForStateChangingFunctions', '')]
    [OutputType([PSMicrosoft365UsageReport.Batch.BatchResponsePayload])]
    [CmdletBinding(
        SupportsShouldProcess = $true, # enables -WhatIf and -Confirm
        ConfirmImpact = 'High'
    )]
    Param(
        [Parameter(
            Mandatory = $true,
            ValueFromPipeline = $true,
            HelpMessage = "One or more BatchRequestPayload objects, each with up to 20 sub-requests."
        )]
        [PSMicrosoft365UsageReport.Batch.BatchRequestPayload[]] $InputObject,
        [Parameter()]
        [switch] $EnableException,
        [Parameter()]
        [switch] $Force
    )

    Begin {
        [string] $service = Get-PSFConfigValue -FullName ('{0}.Settings.DefaultService' -f $script:ModuleName)
        Assert-EntraConnection -Service $service -Cmdlet $PSCmdlet
        [int] $commandRetryCount = Get-PSFConfigValue -FullName ('{0}.Settings.Command.RetryCount' -f $script:ModuleName)
        [TimeSpan] $commandRetryWait = New-TimeSpan -Seconds (Get-PSFConfigValue -FullName ('{0}.Settings.Command.RetryWaitInSeconds' -f $script:ModuleName))
        [string] $path = '$batch'
        [hashtable] $header = @{ 'Content-Type' = 'application/json' }
        if ($Force.IsPresent -and (-not $Confirm.IsPresent)) {
            [bool] $cmdLetConfirm = $false
        }
        else {
            [bool] $cmdLetConfirm = $true
        }
    }

    Process {
        foreach ($payload in $InputObject) {

            [hashtable] $body = @{
                'requests' = @($payload.Requests | Select-Object -Property @{ Name = 'id'; Expression = { $PSItem.Id } } `
                        , @{ Name = 'method'; Expression = { $PSItem.Method } } `
                        , @{ Name = 'url'; Expression = { $PSItem.Url } } `
                        , @{ Name = 'headers'; Expression = { $PSItem.Headers } } `
                        , @{ Name = 'body'; Expression = { $PSItem.Body } }
                )
            }

            Invoke-PSFProtectedCommand -ActionString 'Batch.Invoke' -ActionStringValues ($payload.Requests.Id -join ",") `
                -Target (Get-PSFLocalizedString -Module $script:ModuleName -Name Identity.Platform) `
                -ScriptBlock {
                $batchResponseList = [System.Collections.Generic.List[psobject]]::New()
                [psobject] $batchResponse = Invoke-EntraRequest -Service $service -Header $header -Path $path -Body $body -Method Post -ErrorAction Stop

                $batchResponse.Responses | ForEach-Object {
                    # Check if body content might be base64 encoded
                    if ($PSItem.body -and $PSItem.body.GetType().Name -eq 'String' -and $PSItem.body.Length -gt 0) {
                        # Test if it looks like base64 (basic check)
                        if ($PSItem.body -match '^[A-Za-z0-9+/]*={0,2}$' -and ($PSItem.body.Length % 4) -eq 0) {
                            try {
                                # Try to decode as base64
                                $decodedBytes = [System.Convert]::FromBase64String($PSItem.body)
                                $decodedContent = [System.Text.Encoding]::UTF8.GetString($decodedBytes)
                                Write-PSFMessage -Level Verbose -Message "Response ID: $($PSItem.Id) - Body appears to be base64 encoded, decoded successfully"

                                # Replace the base64 body with decoded content
                                $PSItem.body = $decodedContent
                            }
                            catch {
                                Write-PSFMessage -Level Verbose -Message "Response ID: $($PSItem.Id) - Body looks like base64 but failed to decode: $($_.Exception.Message)"
                            }
                        }
                    }

                    # Handle Graph API pagination structure (value + @odata.nextLink)
                    if ($PSItem.body -and $PSItem.body.GetType().Name -ne 'String') {
                        # If body is already an object (not string), check for Graph API structure
                        if ($PSItem.body.value) {
                            Write-PSFMessage -Level Verbose -Message "Response ID: $($PSItem.Id) - Found paginated response with $($PSItem.body.value.Count) items on first page"

                            # Collect all data from pagination
                            $allData = [System.Collections.Generic.List[object]]::new()
                            $allData.AddRange([array]$PSItem.body.value)

                            # Follow pagination links
                            $nextLink = $PSItem.body.'@odata.nextLink'
                            if ($nextLink) {
                                $nextLink = $nextLink.Trim()
                            }
                            $pageCount = 1

                            while ($nextLink) {
                                $pageCount++
                                Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - Following pagination link (page $pageCount): $nextLink"

                                try {
                                    $nextPage = Invoke-EntraRequest -Service $service -Path $nextLink -Method Get -ErrorAction Stop

                                    if ($nextPage.value) {
                                        $allData.AddRange([array]$nextPage.value)
                                        Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - Retrieved page $pageCount with $($nextPage.value.Count) items (total: $($allData.Count))"
                                    }

                                    $nextLink = $nextPage.'@odata.nextLink'
                                    if ($nextLink) {
                                        $nextLink = $nextLink.Trim()
                                        Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - Next link found: $nextLink"
                                    } else {
                                        Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - No more pages"
                                    }
                                }
                                catch {
                                    Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - Failed to retrieve pagination page $pageCount : $($_.Exception.Message)"
                                    break
                                }
                            }

                            Write-PSFMessage -Level Verbose -Message "Response ID: $($PSItem.Id) - Pagination complete: collected $($allData.Count) total items from $pageCount pages"

                            # Replace with all collected data
                            $PSItem.body = $allData.ToArray()
                        }
                    }
                    elseif ($PSItem.body -and $PSItem.body.GetType().Name -eq 'String') {
                        # If body is string, try to parse as JSON and then handle pagination
                        try {
                            $jsonObject = $PSItem.body | ConvertFrom-Json
                            if ($jsonObject.value) {
                                Write-PSFMessage -Level Verbose -Message "Response ID: $($PSItem.Id) - Found paginated JSON response with $($jsonObject.value.Count) items on first page"

                                # Collect all data from pagination
                                $allData = [System.Collections.Generic.List[object]]::new()
                                $allData.AddRange([array]$jsonObject.value)

                                # Follow pagination links
                                $nextLink = $jsonObject.'@odata.nextLink'
                                if ($nextLink) {
                                    $nextLink = $nextLink.Trim()
                                }
                                $pageCount = 1

                                while ($nextLink) {
                                    $pageCount++
                                    Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - JSON string - Following pagination link (page $pageCount): $nextLink"

                                    try {
                                        $nextPage = Invoke-EntraRequest -Service $service -Path $nextLink -Method Get -ErrorAction Stop
                                        
                                        Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - Page $pageCount response type: $($nextPage.GetType().Name)"

                                        # Check if nextPage is already an array (Invoke-EntraRequest auto-paginated)
                                        if ($nextPage -is [array]) {
                                            Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - Page $pageCount returned array directly with $($nextPage.Count) items"
                                            if ($nextPage.Count -gt 0) {
                                                $firstItemProps = $nextPage[0].PSObject.Properties.Name
                                                Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - Page $pageCount first array item has properties: $($firstItemProps -join ', ')"
                                            }
                                            $allData.AddRange($nextPage)
                                            Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - Retrieved page $pageCount with $($nextPage.Count) items (total: $($allData.Count))"
                                            break  # Invoke-EntraRequest already handled all pagination
                                        }
                                        elseif ($nextPage.value) {
                                            # Check if the first item of this page has data
                                            if ($nextPage.value.Count -gt 0) {
                                                $firstItemProps = $nextPage.value[0].PSObject.Properties.Name
                                                Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - Page $pageCount first item has properties: $($firstItemProps -join ', ')"
                                                Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - Page $pageCount first item userPrincipalName: '$($nextPage.value[0].userPrincipalName)'"
                                            }
                                            
                                            $allData.AddRange([array]$nextPage.value)
                                            Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - Retrieved page $pageCount with $($nextPage.value.Count) items (total: $($allData.Count))"
                                        } else {
                                            Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - Page $pageCount has no 'value' property and is not an array"
                                        }

                                        $nextLink = $nextPage.'@odata.nextLink'
                                        if ($nextLink) {
                                            $nextLink = $nextLink.Trim()
                                            Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - Next link found: $nextLink"
                                        } else {
                                            Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - No more pages"
                                        }
                                    }
                                    catch {
                                        Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - Failed to retrieve pagination page $pageCount : $($_.Exception.Message)"
                                        break
                                    }
                                }

                                Write-PSFMessage -Level Verbose -Message "Response ID: $($PSItem.Id) - Pagination complete: collected $($allData.Count) total items from $pageCount pages"

                                # Verify data integrity before replacing
                                if ($allData.Count -gt 200) {
                                    Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - Verifying data: Item[0] has userPrincipalName='$($allData[0].userPrincipalName)', Item[200] has userPrincipalName='$($allData[200].userPrincipalName)'"
                                }

                                # Replace with all collected data
                                $PSItem.body = $allData.ToArray()
                                
                                # Verify after assignment
                                if ($PSItem.body.Count -gt 200) {
                                    Write-PSFMessage -Level Warning -Message "Response ID: $($PSItem.Id) - After assignment: body.Count=$($PSItem.body.Count), body[0].userPrincipalName='$($PSItem.body[0].userPrincipalName)', body[200].userPrincipalName='$($PSItem.body[200].userPrincipalName)'"
                                }
                            }
                            else {
                                # Keep the parsed JSON object
                                $PSItem.body = $jsonObject
                            }
                            Write-PSFMessage -Level Verbose -Message "Response ID: $($PSItem.Id) - Converted JSON string to object"
                        }
                        catch {
                            Write-PSFMessage -Level Verbose -Message "Response ID: $($PSItem.Id) - Body is string but not valid JSON: $($_.Exception.Message)"
                        }
                    }

                    [void] $batchResponseList.Add($PSItem)
                }

                [PSMicrosoft365UsageReport.Batch.BatchResponsePayload]@{
                    Requests  = $payload.Requests
                    Responses = [PSMicrosoft365UsageReport.Batch.Response[]] ($batchResponseList | Select-Object -Property @{ Name = 'Id'; Expression = { $PSItem.Id } } `
                            , @{ Name = 'Status'; Expression = { $PSItem.status } } `
                            , @{ Name = 'Headers'; Expression = { $PSItem.headers } } `
                            , @{ Name = 'Body'; Expression = { $PSItem.body } })
                }
            } -EnableException:$EnableException -Confirm:$cmdLetConfirm -PSCmdlet $PSCmdlet -Continue -RetryCount $commandRetryCount -RetryWait $commandRetryWait
            if (Test-PSFFunctionInterrupt) { return }
        }
    }

    End {
        # End block - cleanup if needed
    }
}

