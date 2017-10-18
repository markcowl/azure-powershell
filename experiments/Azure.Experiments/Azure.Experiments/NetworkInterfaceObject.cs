﻿using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using System.Threading.Tasks;

namespace Azure.Experiments
{
    public sealed class NetworkInterfaceObject
        : ResourceObject<NetworkInterface, INetworkInterfacesOperations>
    {
        public NetworkInterfaceObject(
            INetworkManagementClient client,
            string name,
            ResourceGroupObject rg, 
            SubnetObject subnet,
            PublicIpAddressObject pia,
            NetworkSecurityGroupObject nsg) 
            : base(name, rg, new AzureObject[] { subnet, pia, nsg })
        {
            Client = client.NetworkInterfaces;
            Pia = pia;
            Subnet = subnet;
        }

        protected override async Task<NetworkInterface> CreateAsync(
            INetworkInterfacesOperations _)
            => await Client.CreateOrUpdateAsync(
                ResourceGroupName,
                Name, 
                new NetworkInterface
                {
                    Location = "eastus",                    
                    IpConfigurations = new[] 
                    {
                        new NetworkInterfaceIPConfiguration
                        {
                            Name = Name,
                            Subnet = Subnet.Info,
                            PublicIPAddress = Pia.Info,
                        }
                    }                    
                });

        protected override INetworkInterfacesOperations CreateClient(Context c)
            => c.CreateNetwork().NetworkInterfaces;

        protected override Task<NetworkInterface> GetOrThrowAsync(
            INetworkInterfacesOperations _)
            => Client.GetAsync(ResourceGroupName, Name);

        private PublicIpAddressObject Pia { get; }

        private SubnetObject Subnet { get; }

        private INetworkInterfacesOperations Client { get; }
    }
}
