using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entities;
using Microsoft.Xrm.Sdk;

namespace Chapter02.Repositories
{
    public class OpportunityRepository : IOpportunityRepository
    {
        protected Dyn365ServiceContext serviceContext;
        protected IOrganizationService orgService;

        public OpportunityRepository(IOrganizationService service)
        {
            this.orgService = service;
            this.serviceContext = new Dyn365ServiceContext(service); 
        }


        public Opportunity GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid Create(Opportunity opportunity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
