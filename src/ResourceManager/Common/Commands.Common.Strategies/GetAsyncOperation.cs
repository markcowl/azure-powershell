﻿using Microsoft.Rest.Azure;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Azure.Commands.Common.Strategies
{
    public static class GetAsyncOperation
    {
        /// <summary>
        /// Get current Azure state related to the given resource.
        /// </summary>
        /// <typeparam name="Model"></typeparam>
        /// <param name="resourceConfig"></param>
        /// <param name="client"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>An Azure state.</returns>
        public static async Task<IState> GetAsync<Model>(
            this IResourceBaseConfig<Model> resourceConfig,
            IClient client,
            CancellationToken cancellationToken)
            where Model : class
        {
            var visitor = new Visitor(client, cancellationToken);
            await visitor.GetOrAdd(resourceConfig);
            return visitor.Result;
        }

        sealed class Visitor : AsyncOperationVisitor
        {
            public override async Task<object> Visit<Model>(ResourceConfig<Model> config)
            {
                Model info;
                try
                {
                    info = await config.Strategy.GetAsync(
                        Client,
                        new GetAsyncParams(
                            config.ResourceGroupName, config.Name, CancellationToken));
                }
                catch (CloudException e) when (e.Response.StatusCode == HttpStatusCode.NotFound)
                {
                    info = null;
                }
                if (info == null)
                {
                    var tasks = config.Dependencies.Select(GetOrAddUntyped);
                    await Task.WhenAll(tasks);
                    return null;
                }
                return info;
            }

            public override async Task<object> Visit<Model, ParentModel>(
                NestedResourceConfig<Model, ParentModel> config)
            {
                var parent = await GetOrAdd(config.Parent);
                return parent == null ? null : config.Strategy.Get(parent, config.Name);
            }

            public Visitor(IClient client, CancellationToken cancellationToken)
                : base(client, cancellationToken)
            {
            }
        }
    }
}
