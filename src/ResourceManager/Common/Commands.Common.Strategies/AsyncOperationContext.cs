﻿using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Azure.Commands.Common.Strategies
{
    /// <summary>
    /// Context for asyncronous operations, such as GetAsync or CreateOrUpdateAsync.
    /// </summary>
    public sealed class AsyncOperationContext
    {
        public IClient Client { get; }

        public CancellationToken CancellationToken { get; }

        public IState Result => _Result;

        public AsyncOperationContext(IClient client, CancellationToken cancellationToken)
        {
            Client = client;
            CancellationToken = cancellationToken;
        }

        public async Task<TModel> GetOrAddAsync<TModel>(
            ResourceConfig<TModel> config, Func<Task<TModel>> operation)
            where TModel : class
            => await _TaskMap.GetOrAddWithCast(
                config.DefaultIdStr(),
                async () =>
                {
                    var model = await operation();
                    if (model != null)
                    {
                        // add the operation result to a result.
                        _Result.GetOrAdd(config, () => model);
                    }
                    return model;
                });

        readonly State _Result = new State();

        readonly ConcurrentDictionary<string, Task> _TaskMap
            = new ConcurrentDictionary<string, Task>();
    }
}
