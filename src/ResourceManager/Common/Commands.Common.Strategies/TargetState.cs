﻿namespace Microsoft.Azure.Commands.Common.Strategies
{
    public static class TargetState
    {
        public static IState GetTargetState<TModel>(
            this ResourceConfig<TModel> config,
            IState current,
            string subscription,
            string location)
            where TModel : class
        {
            var context = new Context(current, subscription, location);
            context.AddIfRequired(config);
            return context.Target;
        }

        sealed class Context
        {
            public State Target { get; } = new State();

            public IState Current { get; }

            public string Subscription { get; }

            public string Location { get; }

            public Context(IState current, string subscription, string location)
            {
                Current = current;
                Subscription = subscription;
                Location = location;
            }

            public void AddIfRequired(IEntityConfig config)
            {
                if (!Current.Contains(config))
                {
                    config.Accept(new AddVisitor(), this);
                }
            }

            public TModel GetOrAdd<TModel>(ResourceConfig<TModel> config)
                where TModel : class
                => Target.GetOrAdd(
                    config,
                    () =>
                    {
                        foreach (var dependency in config.Dependencies)
                        {
                            AddIfRequired(dependency);
                        }
                        var model = config.CreateModel(Subscription);
                        config.Strategy.SetLocation(model, Location);
                        return model;
                    });

            public TModel GetOrAdd<TModel, TParentModel>(
                NestedResourceConfig<TModel, TParentModel> config)
                where TModel : class
                where TParentModel : class
            {
                var parentModel = config.Parent.Accept(new GetOrAddVisitor<TParentModel>(), this);
                var model = config.Strategy.Get(parentModel, config.Name);
                if (model == null)
                {
                    model = config.CreateModel();
                    config.Strategy.CreateOrUpdate(parentModel, config.Name, model);
                }
                return model;
            }
        }

        sealed class AddVisitor : IEntityConfigVisitor<Context, Void>
        {
            public Void Visit<TModel>(ResourceConfig<TModel> config, Context context)
                where TModel : class
            {
                context.GetOrAdd(config);
                return new Void();
            }

            public Void Visit<TModel, TParentModel>(
                NestedResourceConfig<TModel, TParentModel> config, Context context)
                where TModel : class
                where TParentModel : class
            {
                context.GetOrAdd(config);
                return new Void();
            }
        }

        sealed class GetOrAddVisitor<TModel> : IEntityConfigVisitor<TModel, Context, TModel>
            where TModel : class
        {
            public TModel Visit(ResourceConfig<TModel> config, Context context)
                => context.GetOrAdd(config);

            public TModel Visit<TParenModel>(
                NestedResourceConfig<TModel, TParenModel> config, Context context)
                where TParenModel : class
                => context.GetOrAdd(config);
        }
    }
}
