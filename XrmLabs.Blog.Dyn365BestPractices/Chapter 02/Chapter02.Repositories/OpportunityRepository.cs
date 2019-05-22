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
    public class OpportunityRepository : RepositoryBase<Opportunity>, IOpportunityRepository
    {
        public OpportunityRepository(IOrganizationService service) : base(service)
        {
        }

        public List<Opportunity> GetByAccountId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
