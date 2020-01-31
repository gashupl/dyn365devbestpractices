using System;
using Common.Entities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Chapter06.Plugins.Common
{
    internal class CdsServiceProvider : ICdsServiceProvider
    {

        public IServiceProvider ServiceProvider { get; private set; }
        public IPluginExecutionContext Context { get; private set; }
        public IOrganizationServiceFactory Factory { get; private set; }
        public Dyn365ServiceContext ServiceContext { get; private set; }

        //public Dyn365ServiceContext ServiceContext { get; }
        public ITracingService TracingService { get; private set; }

        public IOrganizationService Service { get; private set; }

        public CdsServiceProvider(IServiceProvider serviceProvider)
        {
            Initialize(serviceProvider, Context.UserId);
        }

        public CdsServiceProvider(IServiceProvider serviceProvider, Guid userId) : this(serviceProvider)
        {
            Initialize(serviceProvider, userId); 
        }

        public CdsServiceProvider(OrganizationServiceProxy serviceProxy)
        {
            this.ServiceProvider = null;
            serviceProxy.EnableProxyTypes();
            serviceProxy.Timeout = new TimeSpan(0, 5, 0);
            this.Service = serviceProxy;
        }

        public CdsServiceProvider(IOrganizationService service)
        {
            this.ServiceProvider = null;
            this.Service = service;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        private void Initialize(IServiceProvider serviceProvider, Guid UserId)
        {
            this.ServiceProvider = serviceProvider;
            this.Context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            Factory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            Service = Factory.CreateOrganizationService(UserId);
            this.ServiceContext = new Dyn365ServiceContext(this.Service);
        }
    }
}
