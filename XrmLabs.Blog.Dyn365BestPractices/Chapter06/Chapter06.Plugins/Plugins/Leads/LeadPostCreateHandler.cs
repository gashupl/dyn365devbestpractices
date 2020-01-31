using System.Collections.Generic;
using Chapter06.Plugins.Commands;
using Chapter06.Plugins.Commands.Base;
using Common.Entities; 

namespace Chapter06.Plugins.Plugins.Leads
{
    public class LeadPostCreateHandler : PluginBase
    {
        public override void RegisterCommands(CdsCommandFactory commandFactory, List<ICdsCommand> registeredActions)
        {
            registeredActions.Add(commandFactory.GetCommand<TryCreateTaskCommand>());
        }
    }
}
