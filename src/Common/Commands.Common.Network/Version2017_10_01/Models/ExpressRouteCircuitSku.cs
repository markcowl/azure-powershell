// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Internal.Network.Version2017_10_01.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains SKU in an ExpressRouteCircuit.
    /// </summary>
    public partial class ExpressRouteCircuitSku
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitSku class.
        /// </summary>
        public ExpressRouteCircuitSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteCircuitSku class.
        /// </summary>
        /// <param name="name">The name of the SKU.</param>
        /// <param name="tier">The tier of the SKU. Possible values are
        /// 'Standard' and 'Premium'. Possible values include: 'Standard',
        /// 'Premium'</param>
        /// <param name="family">The family of the SKU. Possible values are:
        /// 'UnlimitedData' and 'MeteredData'. Possible values include:
        /// 'UnlimitedData', 'MeteredData'</param>
        public ExpressRouteCircuitSku(string name = default(string), string tier = default(string), string family = default(string))
        {
            Name = name;
            Tier = tier;
            Family = family;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the SKU.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the tier of the SKU. Possible values are 'Standard'
        /// and 'Premium'. Possible values include: 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets the family of the SKU. Possible values are:
        /// 'UnlimitedData' and 'MeteredData'. Possible values include:
        /// 'UnlimitedData', 'MeteredData'
        /// </summary>
        [JsonProperty(PropertyName = "family")]
        public string Family { get; set; }

    }
}
