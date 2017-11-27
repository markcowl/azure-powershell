﻿using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using Microsoft.Azure.Management.ResourceManager.Models;
using System.Linq;

namespace Microsoft.Azure.Commands.Common.Strategies.Network
{
    public static class NetworkSecurityGroupStrategy
    {
        public static ResourceStrategy<NetworkSecurityGroup> Strategy { get; }
            = NetworkStrategy.Create(
                "networkSecurityGroups",
                client => client.NetworkSecurityGroups,
                (o, p) => o.GetAsync(
                    p.ResourceGroupName, p.Name, null, p.CancellationToken),
                (o, p) => o.CreateOrUpdateAsync(
                    p.ResourceGroupName, p.Name, p.Model, p.CancellationToken));

        public static ResourceConfig<NetworkSecurityGroup> CreateNetworkSecurityGroupConfig(
            this ResourceConfig<ResourceGroup> resourceGroup, string name, int[] openPorts)
            => Strategy.CreateConfig(
                resourceGroup,
                name,
                _ => new NetworkSecurityGroup
                {
                    SecurityRules = openPorts
                        .Select((port, index) => new SecurityRule
                        {
                            Name = name + port,
                            Protocol = "Tcp",
                            Priority = index + 1000,
                            Access = "Allow",
                            Direction = "Inbound",
                            SourcePortRange = "*",
                            SourceAddressPrefix = "*",
                            DestinationPortRange = port.ToString(),
                            DestinationAddressPrefix = "*"
                        })
                        .ToList()
                });
    }
}
