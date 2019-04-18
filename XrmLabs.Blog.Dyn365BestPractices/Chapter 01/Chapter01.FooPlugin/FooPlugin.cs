using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;

namespace Chapter01.FooPlugin
{
    public class FooPlugin : PluginBase
    {
        public FooPlugin(string unsecureString, string secureString) : base(unsecureString, secureString)
        {
        }

        public override bool IsContextValid(IPluginExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public override void Execute(IPluginExecutionContext pluginExecutionContext, ITracingService tracingService)
        {
            throw new NotImplementedException();
        }
    }
}
