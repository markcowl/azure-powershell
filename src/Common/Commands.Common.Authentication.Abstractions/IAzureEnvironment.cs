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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Azure.Commands.Common.Authentication.Abstractions
{
    public interface IAzureEnvironment : ISerializable
    {
        string Name { get; set; }

        bool OnPremise { get; set; }

        Uri ServiceManagement { get; set; }

        Uri ResourceManager { get; set; }

        Uri ManagementPortalUrl { get; set; }

        Uri ActiveDirectory { get; set; }

        Uri Gallery { get; set; }

        Uri Graph { get; set; }

        string ActiveDirectoryServiceEndpointResourceId { get; set; }

        string StorageEndpointSuffix { get; set; }

        string SqlDatabaseDnsSuffix { get; set; }

        string TrafficManagerDnsSuffix { get; set; }

        string AzureKeyVaultDnsSuffix { get; set; }

        string AzureKeyVaultServiceEndpointResourceId { get; set; }

        string GraphEndpointResourceId { get; set; }

        IList<string> VersionProfiles { get; }
       
        IDictionary<string, string> ExtendedProperties { get; set; }
    }
}
