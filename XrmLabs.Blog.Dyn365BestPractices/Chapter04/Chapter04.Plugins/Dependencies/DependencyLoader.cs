using Chapter04.Plugins.Repositories;
using SimpleInjector;

namespace Chapter04.Plugins.Dependencies
{
    class DependencyLoader : IDependencyLoader
    {
        public void RegisterDependencies(Container container)
        {
            container.Register<IOpportunityRepository, OpportunityRepository>();
            //container.Register<ILogger, FileLogger>(Lifestyle.Singleton);


            // 3. Verify your configuration
            container.Verify();
        }
    }
}
