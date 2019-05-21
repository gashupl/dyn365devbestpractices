using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02.Repositories
{
    public interface IOpportunityRepository
    {
        Opportunity GetById(Guid id);

        Guid Create(Opportunity opportunity); 

        void SaveChanges(); 

    }
}
