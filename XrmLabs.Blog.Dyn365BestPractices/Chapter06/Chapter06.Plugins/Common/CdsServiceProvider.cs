using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace Chapter06.Plugins.Common
{
    internal class CdsServiceProvider : ICdsServiceProvider
    {

        public IServiceProvider ServiceProvider { get; }
        public IPluginExecutionContext Context { get; }
        public IOrganizationServiceFactory Factory { get; }

        public Dyn365ServiceContext ServiceContext { get; }
        public ITracingService TracingService { get; }

       
        private IOrganizationService service = null;
        public IOrganizationService Service
        {
            get
            {
                if (service == null)
                {
                    service = Factory.CreateOrganizationService(Context.UserId);
                }
                return service;
            }
        }

        public CdsServiceProvider(IServiceProvider serviceProvider)
        {
            this.ServiceProvider = serviceProvider;
        }

        public CdsServiceProvider(IServiceProvider serviceProvider, Guid UserId) : this(serviceProvider)
        {
            this.CreateOrganizationServiceForUser(UserId);
        }

        public CdsServiceProvider(OrganizationServiceProxy service)
        {
            this.ServiceProvider = null;
            service.EnableProxyTypes();
            service.Timeout = new TimeSpan(0, 5, 0);
            this.service = service;
        }

        public CdsServiceProvider(IOrganizationService service)
        {
            this.ServiceProvider = null;
            this.service = service;
        }

        private void CreateOrganizationServiceForUser(Guid UserId)
        {
            if (service == null)
            {
                service = Factory.CreateOrganizationService(UserId);
            }
            else
            {
                throw new InvalidPluginExecutionException("Organization Service has already been created.");
            }

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
