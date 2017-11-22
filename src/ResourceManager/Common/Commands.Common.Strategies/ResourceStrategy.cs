﻿using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Azure.Commands.Common.Strategies
{
    public sealed class ResourceStrategy<Model> : IEntityStrategy
    {
        public Func<string, IEnumerable<string>> GetId { get; }

        public Func<IClient, GetAsyncParams, Task<Model>> GetAsync { get; }

        public Func<IClient, CreateOrUpdateAsyncParams<Model>, Task<Model>> CreateOrUpdateAsync { get; }

        public Func<Model, string> GetLocation { get; }

        public Action<Model, string> SetLocation { get; }

        public ResourceStrategy(
            Func<string, IEnumerable<string>> getId,
            Func<IClient, GetAsyncParams, Task<Model>> getAsync,
            Func<IClient, CreateOrUpdateAsyncParams<Model>, Task<Model>> createOrUpdateAsync,
            Func<Model, string> getLocation,
            Action<Model, string> setLocation)
        {
            GetId = getId;
            GetAsync = getAsync;
            CreateOrUpdateAsync = createOrUpdateAsync;
            GetLocation = getLocation;
            SetLocation = setLocation;
        }
    }

    public static class ResourceStrategy
    {
        public static ResourceStrategy<Model> Create<Model, Client, Operations>(
            Func<string, IEnumerable<string>> getId,
            Func<Client, Operations> getOperations,
            Func<Operations, GetAsyncParams, Task<Model>> getAsync,
            Func<Operations, CreateOrUpdateAsyncParams<Model>, Task<Model>> createOrUpdateAsync,
            Func<Model, string> getLocation,
            Action<Model, string> setLocation)
            where Client : ServiceClient<Client>
        {
            Func<IClient, Operations> toOperations = client => getOperations(client.GetClient<Client>());
            return new ResourceStrategy<Model>(
                getId,
                (client, p) => getAsync(toOperations(client), p),
                (client, p) => createOrUpdateAsync(toOperations(client), p),
                getLocation,
                setLocation);
        }

        public static ResourceStrategy<Model> Create<Model, Client, Operations>(
            IEnumerable<string> headers,
            Func<Client, Operations> getOperations,
            Func<Operations, GetAsyncParams, Task<Model>> getAsync,
            Func<Operations, CreateOrUpdateAsyncParams<Model>, Task<Model>> createOrUpdateAsync,
            Func<Model, string> getLocation,
            Action<Model, string> setLocation)
            where Client : ServiceClient<Client>
            => Create(
                name => new[] { "providers" }.Concat(headers).Concat(new[] { name }),
                getOperations,
                getAsync,
                createOrUpdateAsync,
                getLocation,
                setLocation);
    }
}
