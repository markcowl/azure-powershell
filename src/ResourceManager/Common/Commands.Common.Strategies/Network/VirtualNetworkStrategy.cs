﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using Microsoft.Azure.Management.ResourceManager.Models;

namespace Microsoft.Azure.Commands.Common.Strategies.Network
{
    public static class VirtualNetworkStrategy
    {
        public static ResourceStrategy<VirtualNetwork> Strategy { get; }
            = NetworkStrategy.Create(
                "virtual network",
                "virtualNetworks",
                client => client.VirtualNetworks,
                (o, p) => o.GetAsync(
                    p.ResourceGroupName, p.Name, null, p.CancellationToken),
                (o, p) => o.CreateOrUpdateAsync(
                    p.ResourceGroupName, p.Name, p.Model, p.CancellationToken));

        public static ResourceConfig<VirtualNetwork> CreateVirtualNetworkConfig(
            this ResourceConfig<ResourceGroup> resourceGroup,
            string name,
            string addressPrefix)
            => Strategy.CreateConfig(
                resourceGroup,
                name,
                _ => new VirtualNetwork
                {
                    AddressSpace = new AddressSpace
                    {
                        AddressPrefixes = new[] { addressPrefix }
                    }
                });
    }
}
