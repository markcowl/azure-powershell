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

using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Commands.Common.Authentication.Models;
using Microsoft.WindowsAzure.Management.HDInsight.Cmdlet.DataObjects;
using Microsoft.WindowsAzure.Management.HDInsight.Logging;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;

namespace Microsoft.WindowsAzure.Management.HDInsight.Cmdlet.GetAzureHDInsightClusters
{
    internal interface IInvokeAzureHDInsightJobCommand
    {
        CancellationToken CancellationToken { get; }

        AzureSubscription CurrentSubscription { get; set; }

        AzureHDInsightClusterConnection Connection { get; set; }

        AzureHDInsightHiveJobDefinition JobDefinition { get; set; }

        string JobId { get; }

        ILogWriter Logger { get; set; }

        ObservableCollection<string> Output { get; }

        void Cancel();

        Task EndProcessing();
    }
}
