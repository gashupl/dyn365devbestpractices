﻿using Common.Entities;
using System;
using System.Collections.Generic;

namespace Chapter02.Repositories
{
    public interface IOpportunityRepository : IRepository<Opportunity>
    {
        List<Opportunity> GetByAccountId(Guid id);

        List<Opportunity> GetSomeData(); 
    }
}
