using Chapter04.Plugins.Repositories;
using Chapter04.Plugins.Services;
using SimpleInjector;

namespace Chapter04.Plugins.Dependencies
{
    public class DependencyLoader : IDependencyLoader
    {
        public void RegisterDependencies(Container container)
        {
            container.Register<IOpportunityRepository, OpportunityRepository>();
            container.Register<OpportunityService, OpportunityService>(); 

            container.Verify();
        }
    }
}
