

#region AzureCommonInitialization

# load the private module
ipmo "$PSScriptRoot/bin/Debug/netstandard2.0/ContainerRegistryManagement.private.dll"

# export the 'exported' cmdlets 
Get-ChildItem "$PSScriptRoot/exported" -Recurse -Filter "*.ps1" -File | Sort-Object Name | Foreach { 
    Write-Verbose "Dot sourcing private script file: $($_.Name)"
    . $_.FullName
    # Explicity export the member
    Export-ModuleMember -Function $_.BaseName
}

$module = Get-Module AzureRM.Profile.Netcore
if ($module -ne $null -and $module.Version.ToString().CompareTo("0.12.0") -lt 0) 
{ 
    Write-Error "This module requires AzureRM.Profile.Netcore version 0.12.0. An earlier version of AzureRM.Profile is imported in the current PowerShell session. Please open a new session before importing this module. This error could indicate that multiple incompatible versions of the Azure PowerShell cmdlets are installed on your system. Please see https://aka.ms/azps-version-error for troubleshooting information." -ErrorAction Stop 
} 
elseif ($module -eq $null) 
{
	$module = ipmo -global -passthru "$PSScriptRoot/../../Package/Debug/ResourceManager/AzureResourceManager/AzureRM.Profile.Netcore/AzureRM.Profile.Netcore.psd1"
}

if ($module) {
  Write-Host "Loaded Common Module '$($module.Name)'"

  # this module instance.
  $instance =  [Sample.API.Module]::Instance

  # ask for the table of functions we can call in the common module.
  $VTable = Register-AzureModule

  # delegate responsibility to the common module for tweaking the pipeline at module load
  $instance.OnModuleLoad = $VTable.OnModuleLoad

  # and a chance to tweak the pipeline when we are about to make a call.
  $instance.OnNewRequest = $VTable.OnNewRequest

  # Need to get parameter values back from the common module
  $instance.GetParameterValue = $VTable.GetParameterValue

  # need to let the common module listen to events from this module
  $instance.EventListener = $VTable.EventListener

  # finish initialization of this module
  $instance.Init();
  }
#endregion
