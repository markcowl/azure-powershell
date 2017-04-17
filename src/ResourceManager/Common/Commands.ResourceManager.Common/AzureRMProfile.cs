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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using System.Collections;
using Microsoft.Azure.Commands.ResourceManager.Common;

namespace Microsoft.Azure.Commands.Common.Authentication.Models
{
    /// <summary>
    /// Represents Azure Resource Manager profile structure with default context, environments and token cache.
    /// </summary>
    [Serializable]
    public sealed class AzureRMProfile : IAzureContextContainer
    {
        /// <summary>
        /// Gets or sets Azure environments.
        /// </summary>
        [JsonConverter(typeof(AzureRmProfileConverter))]
        public Dictionary<string, IAzureEnvironment> EnvironmentTable { get; set; }

        [JsonConverter(typeof(AzureRmProfileConverter))]
        public Dictionary<string, IAzureContext> Contexts = new Dictionary<string, IAzureContext>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Gets the path of the profile file. 
        /// </summary>
        [JsonIgnore]
        public string ProfilePath { get; private set; }

        /// <summary>
        /// Gets the default context
        /// </summary>
        [JsonConverter(typeof(AzureRmProfileConverter))]
        public IAzureContext DefaultContext { get; set;}

        [JsonConverter(typeof(AzureRmProfileConverter))]
        public IEnumerable<IAzureEnvironment> Environments
        {
            get
            {
                return EnvironmentTable.Values;
            }
        }

        [JsonConverter(typeof(AzureRmProfileConverter))]
        public IEnumerable<IAzureSubscription> Subscriptions
        {
            get
            {
                return Contexts.Values.Select((c) => c.Subscription);
            }
        }

        [JsonConverter(typeof(AzureRmProfileConverter))]
        public IEnumerable<IAzureAccount> Accounts
        {
            get
            {
                return Contexts.Values.Select((c) => c.Account);
            }
        }

        [JsonConverter(typeof(AzureRmProfileConverter))]
        public IAzureTokenCache TokenStore { get; set; } = new AzureTokenCache();

        public IDictionary<string, string> ExtendedProperties { get; } = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        public ICollection<string> Keys
        {
            get
            {
                return Contexts.Keys;
            }
        }

        [JsonIgnore]
        public ICollection<IAzureContext> Values
        {
            get
            {
                return Contexts.Values;
            }
        }

        public int Count
        {
            get
            {
                return Contexts.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        [JsonIgnore]
        public IAzureContext this[string key]
        {
            get
            {
                return Contexts[key];
            }

            set
            {
                Contexts[key] = value;
            }
        }

        private void Load(string path)
        {
            this.ProfilePath = path;

            if (!AzureSession.Instance.DataStore.DirectoryExists(AzureSession.Instance.ProfileDirectory))
            {
                AzureSession.Instance.DataStore.CreateDirectory(AzureSession.Instance.ProfileDirectory);
            }

            if (AzureSession.Instance.DataStore.FileExists(ProfilePath))
            {
                string contents = AzureSession.Instance.DataStore.ReadFileAsText(ProfilePath);
                var profile = JsonConvert.DeserializeObject<AzureRMProfile>(contents, new AzureRmProfileConverter());
                Debug.Assert(profile != null);
                DefaultContext = profile.DefaultContext;
                EnvironmentTable.Clear();
                foreach (var environment in profile.Environments)
                {
                    EnvironmentTable[environment.Name] = environment;
                }
            }
        }

        /// <summary>
        /// Creates new instance of AzureRMProfile.
        /// </summary>
        public AzureRMProfile()
        {
            EnvironmentTable = new Dictionary<string, IAzureEnvironment>(StringComparer.InvariantCultureIgnoreCase);

            // Adding predefined environments
            foreach (AzureEnvironment env in AzureEnvironment.PublicEnvironments.Values)
            {
                EnvironmentTable[env.Name] = env;
            }
        }

        /// <summary>
        /// Initializes a new instance of AzureRMProfile and loads its content from specified path.
        /// </summary>
        /// <param name="path">The location of profile file on disk.</param>
        public AzureRMProfile(string path) : this()
        {
            Load(path);
        }

        /// <summary>
        /// Writes profile to the disk it was opened from disk.
        /// </summary>
        public void Save()
        {
            if (!string.IsNullOrEmpty(ProfilePath))
            {
                Save(ProfilePath);
            }
        }

        /// <summary>
        /// Writes profile to a specified path.
        /// </summary>
        /// <param name="path">File path on disk to save profile to</param>
        public void Save(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            // Removing predefined environments
            foreach (string env in AzureEnvironment.PublicEnvironments.Keys)
            {
                EnvironmentTable.Remove(env);
            }

            try
            {
                string contents = ToString();
                string diskContents = string.Empty;
                if (AzureSession.Instance.DataStore.FileExists(path))
                {
                    diskContents = AzureSession.Instance.DataStore.ReadFileAsText(path);
                }

                if (diskContents != contents)
                {
                    AzureSession.Instance.DataStore.WriteFile(path, contents);
                }
            }
            finally
            {
                // Adding back predefined environments
                foreach (AzureEnvironment env in AzureEnvironment.PublicEnvironments.Values)
                {
                    EnvironmentTable[env.Name] = env;
                }
            }
        }

        /// <summary>
        /// Serializes the current profile and return its contents.
        /// </summary>
        /// <returns>The current string.</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public bool ContainsKey(string key)
        {
            return Contexts.ContainsKey(key);
        }

        public void Add(string key, IAzureContext value)
        {
            Contexts.Add(key, value);
        }

        public bool Remove(string key)
        {
            return Contexts.Remove(key);
        }

        public bool TryGetValue(string key, out IAzureContext value)
        {
            return Contexts.TryGetValue(key, out value);
        }

        public void Add(KeyValuePair<string, IAzureContext> item)
        {
            Contexts.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            Contexts.Clear();
        }

        public bool Contains(KeyValuePair<string, IAzureContext> item)
        {
            return Contexts.Contains(item);
        }

        public void CopyTo(KeyValuePair<string, IAzureContext>[] array, int arrayIndex)
        {
            if (arrayIndex + Contexts.Count > array.Length)
            {
                throw new ArgumentOutOfRangeException("arrayIndex", "Array not large enough to receive contexts");
            }

            foreach (var pair in Contexts)
            {
                array[arrayIndex++] = pair;
            }
        }

        public bool Remove(KeyValuePair<string, IAzureContext> item)
        {
            return Contexts.Remove(item.Key);
        }

        public IEnumerator<KeyValuePair<string, IAzureContext>> GetEnumerator()
        {
            return Contexts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Contexts.GetEnumerator();
        }
    }
}
