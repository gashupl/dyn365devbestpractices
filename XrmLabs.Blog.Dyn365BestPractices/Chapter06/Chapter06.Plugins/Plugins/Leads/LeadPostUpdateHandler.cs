using System;
using System.Collections.Generic;
using Chapter06.Plugins.Commands;
using Common.Entities;

namespace Chapter06.Plugins.Plugins.Leads
{
    public class LeadPostUpdateHandler : PluginBase<Lead>
    {
        public override void RegisterCommands(CdsCommandFactory<Lead> actionFactory, List<ICdsCommand> registeredActions)
        {
        }
    }
}
