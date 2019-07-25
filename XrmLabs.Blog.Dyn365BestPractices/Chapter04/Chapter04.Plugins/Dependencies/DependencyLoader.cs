using Chapter04.Plugins.Repositories;
using Chapter04.Plugins.Services;
using SimpleInjector;

namespace Chapter04.Plugins.Dependencies
{
    class DependencyLoader : IDependencyLoader
    {
        public void RegisterDependencies(Container container)
        {
            container.Register<IOpportunityRepository, OpportunityRepository>();
            container.Register<OpportunityTestService, OpportunityTestService>(); 

            container.Verify();
        }
    }
}
