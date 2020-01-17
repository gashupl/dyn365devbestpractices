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

        public abstract void RegisterCommands(CdsCommandFactory<E> commandsFactory, List<ICdsCommand> registeredCommands);

        public void Execute(IServiceProvider serviceProvider)
        {
            using (var crmSericeProvider = new CdsServiceProvider(serviceProvider))
            {
                var commandsFactory = new CdsCommandFactory<E>(crmSericeProvider, this.CdsUnitOfWorkRepository);
                var registeredCommands = new List<ICdsCommand>();

                RegisterCommands(commandsFactory, registeredCommands);

                foreach (ICdsCommand command in registeredCommands)
                {
                    var actionName = command.GetType().Name.ToString();

                    if (command.CanExecute())
                    {
                        crmSericeProvider.TracingService.Trace($"{actionName} - execution started");
                        command.Execute();
                        crmSericeProvider.TracingService.Trace($"{actionName} - execution completed" );
                    }
                }
            }
        }
    }
}
