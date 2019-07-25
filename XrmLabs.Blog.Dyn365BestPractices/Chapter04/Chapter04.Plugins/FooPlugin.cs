using Chapter04.FooPlugin;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter04.Plugins.Dependencies;

namespace Chapter04.Plugins
{
    public class FooPlugin : PluginBase
    {

        public override IDependencyLoader DependencyLoader { get; protected set; } = new DependencyLoader(); 
        public FooPlugin(string unsecureString, string secureString) : base(unsecureString, secureString)
        {
        }

        public override void Execute(IPluginExecutionContext pluginExecutionContext, IOrganizationServiceFactory serviceFactory, ITracingService tracingService)
        {
            throw new NotImplementedException();
        }



        public override bool IsContextValid(IPluginExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
