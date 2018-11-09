
// ----------------------------------------------------------------------------------
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

using AutoMapper;
using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using System.Net;

namespace Microsoft.Azure.Commands.Network
{
    public abstract class VirtualNetworkBaseCmdlet : NetworkBaseCmdlet
    {
        public IVirtualNetworksOperations VirtualNetworkClient
        {
            get
            {
                return NetworkClient.NetworkManagementClient.VirtualNetworks;
            }
        }

        public bool IsVirtualNetworkPresent(string resourceGroupName, string name)
        {
            this.NetworkClient.DebugLogger("Checking for presence of network");
            try
            {
                GetVirtualNetwork(resourceGroupName, name);
            }
            catch (Microsoft.Rest.Azure.CloudException exception)
            {

                this.NetworkClient.DebugLogger("Got execption while checking network presence");
                if (exception.Response.StatusCode == HttpStatusCode.NotFound)
                {
                    // Resource is not present
                    return false;
                }

                throw;
            }

            this.NetworkClient.DebugLogger("Network was found");
            return true;
        }

        public PSVirtualNetwork GetVirtualNetwork(string resourceGroupName, string name, string expandResource = null)
        {
            this.NetworkClient.DebugLogger("Calloing network Get");
            var vnt = this.VirtualNetworkClient.GetWithHttpMessagesAsync(resourceGroupName, name).ConfigureAwait(false).GetAwaiter().GetResult();
            this.NetworkClient.DebugLogger("Doing second network Get");
            var vnet = this.VirtualNetworkClient.Get(resourceGroupName, name, expandResource);
            this.NetworkClient.DebugLogger("End calling network Get");

            this.NetworkClient.DebugLogger("Begin network mapping");
            NetworkResourceManagerProfile.Logger = this.NetworkClient.DebugLogger;
            var psVirtualNetwork = NetworkResourceManagerProfile.Mapper.Map<PSVirtualNetwork>(vnet);
            psVirtualNetwork.ResourceGroupName = resourceGroupName;

            this.NetworkClient.DebugLogger("Created network mapping");
            psVirtualNetwork.Tag =
                TagsConversionHelper.CreateTagHashtable(vnet.Tags);

            if (psVirtualNetwork.DhcpOptions == null)
            {
                psVirtualNetwork.DhcpOptions = new PSDhcpOptions();
            }

            this.NetworkClient.DebugLogger("Network object fully mapped");
            return psVirtualNetwork;
        }

        public PSVirtualNetwork ToPsVirtualNetwork(Microsoft.Azure.Management.Network.Models.VirtualNetwork vnet)
        {
            var psVnet = NetworkResourceManagerProfile.Mapper.Map<PSVirtualNetwork>(vnet);

            psVnet.Tag = TagsConversionHelper.CreateTagHashtable(vnet.Tags);

            return psVnet;
        }
    }
}