using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

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


        //public Opportunity GetById(Guid id)
        //{
        //    return this.serviceContext.OpportunitySet.FirstOrDefault(o => o.Id == id); 
        //}

        //public void Create(Opportunity opportunity)
        //{
        //    this.serviceContext.AddObject(opportunity); 
        //}

        //public void SaveChanges()
        //{
        //    this.serviceContext.SaveChanges(); 
        //}

        public Opportunity GetById(Guid id)
        {
            return this.orgService.Retrieve(Opportunity.EntityLogicalName, id, new ColumnSet(true))?.ToEntity<Opportunity>(); 
        }

        public Guid Create(Opportunity opportunity)
        {
            return this.orgService.Create(opportunity); 
        }

    }
}
