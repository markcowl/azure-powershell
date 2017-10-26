﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Network.Models;
using Microsoft.Azure.Management.Network;

namespace Microsoft.Azure.Experiments.Network
{
    public sealed class PublicIpAddressParameters 
        : ResourceParameters<PublicIPAddress>
    {
        public PublicIpAddressParameters(
            string name, ResourceGroupParameters resourceGroup)
            : base(name, resourceGroup, NoDependencies)
        {
        }

        protected override Task<PublicIPAddress> GetAsync(GetContext context)
            => context
                .Context
                .CreateNetwork()
                .PublicIPAddresses
                .GetAsync(ResourceGroup.Name, Name);
    }
}
