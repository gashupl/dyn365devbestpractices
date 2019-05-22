using Common.Entities;
using System;

namespace Chapter02.Repositories
{
    public interface IOpportunityRepository
    {
        //Opportunity GetById(Guid id);

        //void Create(Opportunity opportunity); 

        //void SaveChanges();

        Opportunity GetById(Guid id);

        Guid Create(Opportunity opportunity);

        void Dispose(); 


    }
}
