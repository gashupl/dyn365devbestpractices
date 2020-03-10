using System;
using System.Collections.Generic;
using Chapter06.Plugins.Commands;
using Chapter06.Plugins.Commands.Base;
using Chapter06.Plugins.Common;
using Chapter06.Plugins.Repositories.Base;
using Microsoft.Xrm.Sdk;

namespace Chapter06.Plugins.Plugins
{
    public abstract class PluginBase: IPlugin
    {
        protected ICdsRepositoryFactory CdsUnitOfWorkRepository { get; private set; }

        public abstract void RegisterCommands(CdsCommandFactory commandsFactory, List<ICdsCommand> registeredCommands); 

        public void Execute(IServiceProvider serviceProvider)
        {
            using (var crmSericeProvider = new CdsServiceProvider(serviceProvider))
            {
                var commandsFactory = new CdsCommandFactory(crmSericeProvider, this.CdsUnitOfWorkRepository);
                var registeredCommands = new List<ICdsCommand>();

                RegisterCommands(commandsFactory, registeredCommands);

                foreach (ICdsCommand command in registeredCommands)
                {
                    var commandName = command.GetType().Name.ToString();

                    if (command.CanExecute())
                    {
                        crmSericeProvider.TracingService.Trace($"{commandName} - execution started");
                        command.Execute();
                        crmSericeProvider.TracingService.Trace($"{commandName} - execution completed" );
                    }
                }
            }
        }
    }
}
