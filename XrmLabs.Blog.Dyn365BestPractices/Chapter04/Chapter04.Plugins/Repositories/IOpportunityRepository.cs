using Common.Entities;
using System;
using System.Collections.Generic;

namespace Chapter04.Repositories
{
    public interface IOpportunityRepository : IRepository<Opportunity>
    {
        List<Opportunity> GetByAccountId(Guid id);

        List<Opportunity> GetSomeData(); 
    }
}
