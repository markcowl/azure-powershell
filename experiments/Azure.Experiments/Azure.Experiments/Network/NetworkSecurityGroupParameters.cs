﻿using System.Threading.Tasks;
using Microsoft.Azure.Management.Network.Models;
using Microsoft.Azure.Management.Network;

namespace Microsoft.Azure.Experiments.Network
{
    public sealed class NetworkSecurityGroupParameters
        : ResourceParameters<NetworkSecurityGroup>
    {
        public NetworkSecurityGroupParameters(
            string name, ResourceGroupParameters resourceGroup) 
            : base(name, resourceGroup, NoDependencies)
        {
        }

        protected override Task<NetworkSecurityGroup> GetAsync(Context context, GetMap map)
            => context
                .CreateNetwork()
                .NetworkSecurityGroups
                .GetAsync(ResourceGroup.Name, Name);
    }
}
