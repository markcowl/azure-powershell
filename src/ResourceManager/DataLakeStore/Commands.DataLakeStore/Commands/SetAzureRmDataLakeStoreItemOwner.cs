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
using System.Management.Automation;
using Microsoft.Azure.Commands.DataLakeStore.Models;
using Microsoft.Azure.Commands.DataLakeStore.Properties;
using Microsoft.WindowsAzure.Commands.Common;

namespace Microsoft.Azure.Commands.DataLakeStore
{
    [Cmdlet(VerbsCommon.Set, "AzureRmDataLakeStoreItemOwner", SupportsShouldProcess = true),
    OutputType(typeof(bool))]
    public class SetAzureDataLakeStoreItemOwner : DataLakeStoreFileSystemCmdletBase
    {
        [Parameter(ValueFromPipelineByPropertyName = true, Position = 0, Mandatory = true,
            HelpMessage = "The DataLakeStore account to execute the filesystem operation in")]
        [ValidateNotNullOrEmpty]
        [Alias("AccountName")]
        public string Account { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Position = 1, Mandatory = true,
            HelpMessage =
                "The path in the specified Data Lake account that should have its ACL set. Can be a file or folder " +
                "In the format '/folder/file.txt', " +
                "where the first '/' after the DNS indicates the root of the file system.")]
        [ValidateNotNull]
        public DataLakeStorePathInstance Path { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Position = 2, Mandatory = true,
            HelpMessage = "The type of owner to set. Valid values are 'user' and 'group'.")]
        [ValidateNotNull]
        public DataLakeStoreEnums.Owner Type { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Position = 3, Mandatory = true,
            HelpMessage = "The AAD object ID of the new owner entity")]
        [ValidateNotNull]
        public Guid Id { get; set; }

        [Deprecated, Parameter(ValueFromPipelineByPropertyName = true, Position = 4, Mandatory = false,
            HelpMessage =
                "Indicates that the ACL should be replaced on the file with the specified ACL without prompting.")]
        public SwitchParameter Force { get; set; }

        public override void ExecuteCmdlet()
        {
            var currentAcl = DataLakeStoreFileSystemClient.GetAclStatus(Path.TransformedPath, Account);
            string group;
            string user;
            if (Type == DataLakeStoreEnums.Owner.Group)
            {
                group = Id.ToString();
                user = currentAcl.Owner;
            }
            else
            {
                group = currentAcl.Group;
                user = Id.ToString();
            }

            ConfirmAction(
                string.Format(Resources.SetDataLakeStoreItemOwner, Path.OriginalPath),
                Path.OriginalPath,
                () =>
                    DataLakeStoreFileSystemClient.SetOwner(Path.TransformedPath, Account, user, group));
        }
    }
}