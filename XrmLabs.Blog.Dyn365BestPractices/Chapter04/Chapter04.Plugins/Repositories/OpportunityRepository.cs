﻿using System;
using System.Collections.Generic;
using System.Linq;
using Common.Entities;

namespace Chapter04.Plugins.Repositories
{
    public class OpportunityRepository : RepositoryBase<Opportunity>, IOpportunityRepository
    {

        public List<Opportunity> GetByAccountId(Guid id)
        {
            var query = this.ServiceContext.OpportunitySet
                .Where(o => o.CustomerId != null && o.CustomerId.Id == id);
            return query.ToList<Opportunity>();
        }

        public List<Opportunity> GetSomeData()
        {
            throw new NotImplementedException();
        }
    }
}
