using Chapter04.Plugins.Repositories;
using Common.Entities;

namespace Chapter04.Plugins.Services
{
    public class OpportunityService : ServiceBase, IOpportunityService
    {
        private IOpportunityRepository opportunityRepository; 
        public OpportunityService(IRepositoryFactory repositoryFactory) : base(repositoryFactory)
        {
            this.opportunityRepository = repositoryFactory.Get<Opportunity, OpportunityRepository>(); 
        }

        public void DoSomething(Opportunity opportunity)
        {
            this.opportunityRepository.Create(new Opportunity() { Name = "Test opportunity" }); 
        }
    }
}
