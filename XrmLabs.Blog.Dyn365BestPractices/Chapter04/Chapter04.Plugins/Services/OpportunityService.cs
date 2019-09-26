using Chapter04.Plugins.Repositories;
using Common.Entities;

namespace Chapter04.Plugins.Services
{
    public class OpportunityService : ServiceBase, IOpportunityService
    {
        private IOpportunityRepository opportunityRepository; 
        public OpportunityService(IRepositoryFactory repositoryFactory) : base(repositoryFactory)
        {
            this.opportunityRepository = repositoryFactory.Get<Opportunity, IOpportunityRepository>(); 
        }

        public void DoSomething(Contact contact)
        {
            this.opportunityRepository.Create(new Opportunity() { Name = "Test opportunity" });
            this.opportunityRepository.SaveChanges(); 
        }
    }
}
