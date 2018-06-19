@{
    ModuleVersion="1.0"
    NestedModules = @(
    "./bin/Debug/netstandard2.0/ContainerRegistryManagement.private.dll"
    "ContainerRegistryManagement.psm1"
    )
    # don't export any actual cmdlets by default
    CmdletsToExport = ''

    # export the functions that we loaded (these are the proxy cmdlets)
    FunctionsToExport = '*-*'
}
