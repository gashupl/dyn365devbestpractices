using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter01.FooPlugin;
using Chapter02.Repositories;
using Chapter03.Plugins.Sample2;
using Common.Entities;
using Microsoft.Xrm.Sdk;

namespace Chapter03.Plugins
{
    public class FooPlugin : PluginBase
    {
        #region Constructor
        public FooPlugin(string unsecureString, string secureString) : base(unsecureString, secureString)
        {
        } 
        #endregion

        public override bool IsContextValid(IPluginExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public override void Execute(IPluginExecutionContext pluginExecutionContext, IOrganizationServiceFactory serviceFactory, ITracingService tracingService)
        {
            var orgService = serviceFactory.CreateOrganizationService(pluginExecutionContext.UserId);
            var factory = new RepositoryFactory(orgService);

            //var opportunityRepo = factory.Get<OpportunityRepository, Opportunity>(); 
            //var data = opportunityRepo.GetSomeData(); 
        }
    }
}
