# Migration Guide for Az 1.0.0

This document describes the changes between the 6.x versions of AzureRM and Az version 1.0.0

## Table of Contents

- [General breaking changes](#general-breaking-changes)
    - [Windows PowerShell 5.1 and .Net 4.7.2](#windows-powershell-51-and-net-472)
    - [Module Name Changes](#module-name-changes)
    - [Temporary Removal of User Login using PSCredential](#temporary-removal-of-user-login-using-pscredential)
    - [Device Login Replaces Web Browser Control](#device-login-replaces-web-browser-control)
- [Breaking changes to Az.Compute (AzureRM.Compute) cmdlets](#breaking-changes-to-azcompute-azurermcompute-cmdlets)
- [Breaking changes to Az.Network (AzureRM.Network) cmdlets](#breaking-changes-to-aznetwork-azurermnetwork-cmdlets)
- [Breaking changes to Az.Resources (AzureRM.Resources) cmdlets](#breaking-changes-to-azresources-azurermresources-cmdlets)
- [Removed modules](#removed-modules)

## General breaking changes

### Windows PowerShell 5.1 and .Net 4.7.2

### Module Name Changes
* AzureRM.* -> Az.*, except for the following modules
  - AzureRM.Profile -> Az.Accounts
  - AzureRM.Insights -> Az.Monitor
  - AzureRM.Tags -> Az.Resources
  - AzureRM.MachineLearningCompute -> Az.MachineLearning
  - AzureRM.UsageAggregates -> Az.Billing
  - AzureRM.Consumption -> Az.Billing
  - AzureRM.DataFactoryV2 -> Az.DataFactory

### Temporary Removal of User Login using PSCredential

### Device Login Replaces Web Browser Control

## Breaking changes to Az.Compute (AzureRM.Compute) cmdlets

## Breaking changes to Az.Network (AzureRM.Network) cmdlets

## Breaking changes to Az.Resources (AzureRM.Resources) cmdlets

- Can no longer specify a Password when creating a Service Principal Credential

## Removed modules

### `AzureRM.Scheduler`


### `AzureRM.SiteRecovery`

