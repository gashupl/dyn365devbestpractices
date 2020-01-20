using System.Collections.Generic;
using Chapter06.Plugins.Commands.Base;
using Common.Entities; 

namespace Chapter06.Plugins.Plugins.Leads
{
    public class LeadPostCreateHandler : PluginBase<Lead>
    {
        public override void RegisterCommands(CdsCommandFactory<Lead> actionFactory, List<ICdsCommand> registeredActions)
        {
            //registeredActions.Add(actionFactory.GetCommand<>());
        }
    }
}
