﻿using System.Threading.Tasks;
using Microsoft.Azure.Management.Network.Models;
using System.Linq;

namespace Microsoft.Azure.Experiments.Network
{
    public sealed class SubnetParameters : Parameters<Subnet>
    {
        public VirtualNetworkParameters VirtualNetwork { get; }

        public SubnetParameters(
            string name, VirtualNetworkParameters virtualNetwork)
            : base(name, new[] { virtualNetwork })
        {
            VirtualNetwork = virtualNetwork;
        }

        protected override async Task<Subnet> GetAsync(Context context, GetMap map)
        {
            var virtualNetwork = await VirtualNetwork.GetOrNullAsync(context, map);
            return virtualNetwork?.Subnets.FirstOrDefault(s => s.Name == Name);
        }
    }
}
