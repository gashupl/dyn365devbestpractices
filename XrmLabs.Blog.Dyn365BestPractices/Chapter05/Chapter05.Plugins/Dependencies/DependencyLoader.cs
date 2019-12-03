using System.ComponentModel;
using Chapter05.Plugins.Repositories;
using Chapter05.Plugins.Services;
using SimpleInjector;
using Container = SimpleInjector.Container;

namespace Chapter05.Plugins.Dependencies
{
    public class DependencyLoader : IDependencyLoader
    {
        public void RegisterDependencies(Container container)
        {
            container.Register<ITaskRepository, TaskRepository>();
            container.Register<NewLeadService, NewLeadService>(); 

            container.Verify();
        }
    }
}
