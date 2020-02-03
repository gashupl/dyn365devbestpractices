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

        public ITracingService TracingService { get; private set; }

        public IOrganizationService Service { get; private set; }

        public CdsServiceProvider(IServiceProvider serviceProvider)
        {
            Initialize(serviceProvider);
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
        private void Initialize(IServiceProvider serviceProvider, Guid? userId = null)
        {
            this.ServiceProvider = serviceProvider;
            this.Context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            this.Factory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            if(userId == null)
            {
                this.Service = Factory.CreateOrganizationService(this.Context.UserId);
            }
            else
            {
                this.Service = Factory.CreateOrganizationService(userId);
            }
            this.TracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            this.ServiceContext = new Dyn365ServiceContext(this.Service);
        }
    }
}
