using Chapter04.Plugins.Repositories;
using Common.Entities;

namespace Chapter04.Plugins.Services
{
    public class OpportunityTestService : ServiceBase, IOpportunityTestService
    {
        private IOpportunityRepository opportunityRepository; 
        public OpportunityTestService(IRepositoryFactory repositoryFactory) : base(repositoryFactory)
        {
            this.opportunityRepository = repositoryFactory.Get<Opportunity, OpportunityRepository>(); 
        }

        void IOpportunityTestService.DoSomething(Opportunity opportunity)
        {
            this.opportunityRepository.Create(new Opportunity() { Name = "Test opportunity" }); 
        }
    }
}
