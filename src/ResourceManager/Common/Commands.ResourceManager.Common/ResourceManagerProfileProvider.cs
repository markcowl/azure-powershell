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

using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common.Authentication.Models;

namespace Microsoft.Azure.Commands.ResourceManager.Common
{
    public class ResourceManagerProfileProvider : AzureRmProfileProvider
    {
        AzureRmProfile _profile = new AzureRmProfile { DefaultContext = new AzureContext() };
        public override void ResetDefaultProfile()
        {
            Profile.TokenStore.Clear();
            base.ResetDefaultProfile();
        }

        public override void SetTokenCacheForProfile(IAzureContextContainer profile)
        {
            base.SetTokenCacheForProfile(profile);
        }

        public override T GetProfile<T>()
        {
            return Profile as T;
        }

        public override IAzureContextContainer Profile
        {
            get
            {
                return _profile;
            }

            set
            {
                _profile = value as AzureRmProfile;
            }
        }

        /// <summary>
        /// Initialize the resource manager profile
        /// </summary>
        public static void InitializeResourceManagerProfile()
        {
            SetInstance(() => new ResourceManagerProfileProvider());
        }

    }
}
