// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure.Commands.Common.Strategies.Compute;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Common.Strategies;
using Microsoft.Azure.Commands.Common.Strategies.ResourceManager;
using System.Threading;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.Common.Strategies.Network;
using Microsoft.Azure.Commands.Compute.Common;
using System.Net;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet
    {
        protected object CreateVirtualMachineScaleSetCreateOrUpdateDynamicParameters()
        {
            dynamicParameters = new RuntimeDefinedParameterDictionary();
            var pResourceGroupName = new RuntimeDefinedParameter();
            pResourceGroupName.Name = "ResourceGroupName";
            pResourceGroupName.ParameterType = typeof(string);
            pResourceGroupName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 1,
                Mandatory = true
            });
            pResourceGroupName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ResourceGroupName", pResourceGroupName);

            var pVMScaleSetName = new RuntimeDefinedParameter();
            pVMScaleSetName.Name = "VMScaleSetName";
            pVMScaleSetName.ParameterType = typeof(string);
            pVMScaleSetName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = true
            });
            pVMScaleSetName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("VMScaleSetName", pVMScaleSetName);

            var pParameters = new RuntimeDefinedParameter();
            pParameters.Name = "VirtualMachineScaleSet";
            pParameters.ParameterType = typeof(VirtualMachineScaleSet);
            pParameters.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 3,
                Mandatory = true
            });
            pParameters.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("VirtualMachineScaleSet", pParameters);

            var pArgumentList = new RuntimeDefinedParameter();
            pArgumentList.Name = "ArgumentList";
            pArgumentList.ParameterType = typeof(object[]);
            pArgumentList.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByStaticParameters",
                Position = 4,
                Mandatory = true
            });
            pArgumentList.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ArgumentList", pArgumentList);

            return dynamicParameters;
        }

        protected void ExecuteVirtualMachineScaleSetCreateOrUpdateMethod(object[] invokeMethodInputParameters)
        {
            string resourceGroupName = (string)ParseParameter(invokeMethodInputParameters[0]);
            string vmScaleSetName = (string)ParseParameter(invokeMethodInputParameters[1]);
            VirtualMachineScaleSet parameters = (VirtualMachineScaleSet)ParseParameter(invokeMethodInputParameters[2]);

            var result = VirtualMachineScaleSetsClient.CreateOrUpdate(resourceGroupName, vmScaleSetName, parameters);
            WriteObject(result);
        }
    }

    public partial class NewAzureComputeArgumentListCmdlet : ComputeAutomationBaseCmdlet
    {
        protected PSArgument[] CreateVirtualMachineScaleSetCreateOrUpdateParameters()
        {
            string resourceGroupName = string.Empty;
            string vmScaleSetName = string.Empty;
            VirtualMachineScaleSet parameters = new VirtualMachineScaleSet();

            return ConvertFromObjectsToArguments(
                 new string[] { "ResourceGroupName", "VMScaleSetName", "Parameters" },
                 new object[] { resourceGroupName, vmScaleSetName, parameters });
        }
    }

    [Cmdlet(VerbsCommon.New, "AzureRmVmss", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(PSVirtualMachineScaleSet))]
    public partial class NewAzureRmVmss : ComputeAutomationBaseCmdlet
    {
        public const string SimpleParameterSet = "SimpleParameterSet";

        protected override void ProcessRecord()
        {
            switch (ParameterSetName)
            {
                case SimpleParameterSet:
                    SimpleParameterSetExecuteCmdlet();
                    break;
                default:
                    ExecuteClientAction(() =>
                    {
                        if (ShouldProcess(this.VMScaleSetName, VerbsCommon.New))
                        {
                            string resourceGroupName = this.ResourceGroupName;
                            string vmScaleSetName = this.VMScaleSetName;
                            VirtualMachineScaleSet parameters = new VirtualMachineScaleSet();
                            ComputeAutomationAutoMapperProfile.Mapper.Map<PSVirtualMachineScaleSet, VirtualMachineScaleSet>(this.VirtualMachineScaleSet, parameters);

                            var result = VirtualMachineScaleSetsClient.CreateOrUpdate(resourceGroupName, vmScaleSetName, parameters);
                            var psObject = new PSVirtualMachineScaleSet();
                            ComputeAutomationAutoMapperProfile.Mapper.Map<VirtualMachineScaleSet, PSVirtualMachineScaleSet>(result, psObject);
                            WriteObject(psObject);
                        }
                    });
                    break;
            }
        }

        public void SimpleParameterSetExecuteCmdlet()
        {
            ResourceGroupName = ResourceGroupName ?? VMScaleSetName;
            InstanceCount = InstanceCount ?? 2;
            VmSku = VmSku ?? "Standard_DS2";
            UpgradePolicyMode = UpgradePolicyMode ?? UpgradeMode.Automatic;

            VirtualNetworkName = VirtualNetworkName ?? VMScaleSetName;
            SubnetName = SubnetName ?? VMScaleSetName;
            PublicIpAddressName = PublicIpAddressName ?? VMScaleSetName;
            DomainNameLabel = DomainNameLabel ?? (VMScaleSetName + ResourceGroupName).ToLower();
            SecurityGroupName = SecurityGroupName ?? VMScaleSetName;
            LoadBalancerName = LoadBalancerName ?? VMScaleSetName;

            // get image
            var image = Images
                .Instance
                .Select(osAndMap =>
                    new { OsType = osAndMap.Key, Image = osAndMap.Value.GetOrNull(ImageName) })
                .First(osAndImage => osAndImage.Image != null);

            BackendPorts = BackendPorts
                ?? (image.OsType == "Windows" ? new[] { 3389, 5985 } : new[] { 22 });

            var resourceGroup = ResourceGroupStrategy.CreateResourceGroupConfig(ResourceGroupName);
            
            var publicIpAddress = resourceGroup.CreatePublicIPAddressConfig(
                name: PublicIpAddressName,
                domainNameLabel: DomainNameLabel,
                allocationMethod: AllocationMethod);
            
            var loadBalancer = resourceGroup.CreateLoadBalancerConfig(
                name: LoadBalancerName);

            var virtualNetwork = resourceGroup.CreateVirtualNetworkConfig(
                name: VirtualNetworkName, addressPrefix: VnetAddressPrefix);

            var subnet = virtualNetwork.CreateSubnet(SubnetName, SubnetAddressPrefix);

            /*
            var networkSecurityGroup = resourceGroup.CreateNetworkSecurityGroupConfig(
                name: SecurityGroupName,
                openPorts: OpenPorts);

            var networkInterface = resourceGroup.CreateNetworkInterfaceConfig(
                Name, subnet, publicIpAddress, networkSecurityGroup);*/

            var virtualMachineScaleSet = resourceGroup.CreateVirtualMachineScaleSetConfig(
                name: VMScaleSetName,
                adminUsername: Credential.UserName,
                adminPassword: new NetworkCredential(string.Empty, Credential.Password).Password,
                image: image.Image);

            var client = new Client(DefaultProfile.DefaultContext);

            var current = virtualMachineScaleSet
                .GetStateAsync(client, new CancellationToken())
                .GetAwaiter()
                .GetResult();

            if (Location == null)
            {
                Location = current.GetLocation(virtualMachineScaleSet);
                if (Location == null)
                {
                    Location = "eastus";
                }
            }

            var target = virtualMachineScaleSet.GetTargetState(current, client.SubscriptionId, Location);

            if (ShouldProcess(VMScaleSetName, VerbsCommon.New))
            {
                var result = virtualMachineScaleSet
                    .UpdateStateAsync(
                        client,
                        target,
                        new CancellationToken(),
                        new ShouldProcessType(this),
                        new ProgressReportType(this))
                    .GetAwaiter()
                    .GetResult();
                WriteObject(result);
            }
        }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false)]
        [AllowNull]
        [ResourceManager.Common.ArgumentCompleters.ResourceGroupCompleter()]
        [Parameter(
            ParameterSetName = SimpleParameterSet,
            Mandatory = false)]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 2,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false)]
        [Alias("Name")]
        [AllowNull]
        [Parameter(
            ParameterSetName = SimpleParameterSet,
            Mandatory = true)]
        public string VMScaleSetName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 3,
            Mandatory = true,
            ValueFromPipelineByPropertyName = false,
            ValueFromPipeline = true)]
        [AllowNull]
        public PSVirtualMachineScaleSet VirtualMachineScaleSet { get; set; }

        // SimpleParameterSet

        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = true)]
        public string ImageName { get; set; } //= "Win2016Datacenter";

        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = true)]
        public PSCredential Credential { get; set; }

        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = false)]
        public int? InstanceCount { get; set; }

        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = false)]
        public string VirtualNetworkName { get; set; }

        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = false)]
        public string SubnetName { get; set; }

        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = false)]
        public string PublicIpAddressName { get; set; }
        
        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = false)]
        public string DomainNameLabel { get; set; }

        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = false)]
        public string SecurityGroupName { get; set; }

        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = false)]
        public string LoadBalancerName { get; set; }

        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = false)]
        public int[] BackendPorts { get; set; }

        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = false)]
        [LocationCompleter]
        public string Location { get; set; }
        
        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = false)]
        public string VmSku { get; set; }

        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = false)]
        public UpgradeMode? UpgradePolicyMode { get; set; }

        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = false)]
        [ValidateSet("Static", "Dynamic")]
        public string AllocationMethod { get; set; } = "Static";
        
        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = false)]
        public string VnetAddressPrefix { get; set; } = "192.168.0.0/16";
        
        [Parameter(ParameterSetName = SimpleParameterSet, Mandatory = false)]
        public string SubnetAddressPrefix { get; set; } = "192.168.1.0/24";
    }
}
