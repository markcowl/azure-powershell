﻿using System.Threading;

namespace Microsoft.Azure.Commands.Common.Strategies
{
    public sealed class GetAsyncParams
    {
        public string ResourceGroupName { get; }

        public string Name { get; }

        public CancellationToken CancellationToken { get; }

        public GetAsyncParams(
            string resourceGroupName,
            string name,
            CancellationToken cancellationToken)
        {
            ResourceGroupName = resourceGroupName;
            Name = name;
            CancellationToken = cancellationToken;
        }
    }
}
