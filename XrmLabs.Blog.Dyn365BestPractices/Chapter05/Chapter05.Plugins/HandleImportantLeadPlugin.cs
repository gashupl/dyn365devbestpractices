using Chapter05.FooPlugin;
using Microsoft.Xrm.Sdk;
using Common.Entities;
using SimpleInjector;
using Chapter05.Plugins.Services;
using Chapter05.Plugins.Repositories;
using Chapter05.Plugins.Services.Common;

namespace Chapter05.Plugins
{
    /// <summary>
    /// Responsible for creating task assigned to sales team
    /// when employee number on lead > 30 
    /// </summary>
    public class HandleImportantLeadPlugin : PluginBase
    { 

        #region Constructor
        public HandleImportantLeadPlugin(string unsecureString, string secureString) : base(unsecureString, secureString)
        {
        }
        #endregion

        public override void Execute(IPluginExecutionContext pluginExecutionContext, Container container)
        {
            var target = this.GetTargetEntity<Lead>(pluginExecutionContext);
            var factory = container.GetInstance<IServicesFactory>(); 

            var testService = factory.Get<INewLeadService>(); 
            testService.TryCreateTaskForLargeEmployeesNumberLeads(target); 
        }

        public override bool IsContextValid(IPluginExecutionContext context)
        {
            if(context.PrimaryEntityName == Lead.EntityLogicalName && (context.MessageName == "Create" || context.MessageName == "Update"))
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }

        public override void RegisterDependencies(Container container)
        {
            container.Register<ITaskRepository, TaskRepository>();
            container.Register<ITeamRepository, TeamRepository>();
            container.Register<INewLeadService, NewLeadService>();
        }
    }
}
