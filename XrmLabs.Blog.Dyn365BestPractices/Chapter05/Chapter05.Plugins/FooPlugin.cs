using Chapter05.FooPlugin;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter05.Plugins.Dependencies;
using Common.Entities;
using SimpleInjector;
using Chapter05.Plugins.Services;
using Chapter05.Plugins.Repositories;

namespace Chapter05.Plugins
{
    public class FooPlugin : PluginBase
    {

        //public override IDependencyLoader DependencyLoader { get; protected set; } = new DependencyLoader(); 
        public FooPlugin(string unsecureString, string secureString) : base(unsecureString, secureString)
        {
        }

        public override void Execute(IPluginExecutionContext pluginExecutionContext, Container container)
        {
            var target = this.GetTargetEntity<Contact>(pluginExecutionContext);
            var factory = container.GetInstance<IServicesFactory>(); 

            var testService = factory.Get<IOpportunityService>(); 
            testService.DoSomething(target); 
        }



        public override bool IsContextValid(IPluginExecutionContext context)
        {
            if(context.PrimaryEntityName == Contact.EntityLogicalName)
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
           
            container.Register<IOpportunityRepository, OpportunityRepository>();
            container.Register<IOpportunityService, OpportunityService>();
        }
    }
}
