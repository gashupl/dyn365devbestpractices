using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter06.Plugins.Commands;
using Chapter06.Plugins.Repositories;
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
