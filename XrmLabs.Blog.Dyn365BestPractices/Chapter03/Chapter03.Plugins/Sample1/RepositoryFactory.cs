using Chapter02.Repositories;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03.Plugins.Sample1
{
    class RepositoryFactory
    {
        private IOrganizationService service;
        public RepositoryFactory(IOrganizationService service)
        {
            this.service = service;
        }
        public OpportunityRepository Get()
        {
            return new OpportunityRepository(this.service);
        }
    }
}
