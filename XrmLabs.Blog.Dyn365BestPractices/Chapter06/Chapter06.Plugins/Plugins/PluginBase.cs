using System;
using System.Collections.Generic;
using Chapter06.Plugins.Commands;
using Chapter06.Plugins.Common;
using Chapter06.Plugins.Repositories.Base;
using Microsoft.Xrm.Sdk;

namespace Chapter06.Plugins.Plugins
{
    public abstract class PluginBase<E> : IPlugin where E: Entity
    {
        protected ICdsUnitOfWorkRepository CdsUnitOfWorkRepository { get; private set; }

        public abstract void RegisterActions(CdsCommandFactory<E> actionFactory, List<ICdsCommand> registeredActions);

        public void Execute(IServiceProvider serviceProvider)
        {
            using (var crmSericeProvider = new CdsServiceProvider(serviceProvider))
            {
                var actionFactory = new CdsCommandFactory<E>(crmSericeProvider, this.CdsUnitOfWorkRepository);
                var registeredActions = new List<ICdsCommand>();

                RegisterActions(actionFactory, registeredActions);

                foreach (ICdsCommand action in registeredActions)
                {
                    var actionName = action.GetType().Name.ToString();

                    if (action.CanExecute())
                    {
                        crmSericeProvider.TracingService.Trace("# {0} - start", actionName);
                        action.Execute();
                        crmSericeProvider.TracingService.Trace("# {0} - end", actionName);
                    }
                }
            }
        }
    }
}
