using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entities;
using Microsoft.Xrm.Sdk;

namespace Chapter06.Plugins.Common
{
    public partial interface ICdsServiceProvider : IDisposable
    {
        #region Properties
        IServiceProvider ServiceProvider { get; }
        IPluginExecutionContext Context { get; }
        IOrganizationServiceFactory Factory { get; }
        IOrganizationService Service { get; }
        Dyn365ServiceContext ServiceContext { get; }
        ITracingService TracingService { get; }
        #endregion

    }
}
