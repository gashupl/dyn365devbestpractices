using Microsoft.Xrm.Sdk;
using System;
using Chapter04.Plugins.Repositories;
using SimpleInjector;

namespace Chapter04.Plugins.Repositories
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private Container container; 

        private IOrganizationService service;
        public RepositoryFactory(Container container)
        {
            this.container = container;
        }
        public T Get<E, T>() where E : Entity where T : RepositoryBase<E>
        {
            var context = container.GetInstance<IPluginExecutionContext>();
            var orgServiceFactory = container.GetInstance<IOrganizationServiceFactory>();
            var instance = container.GetInstance<IRepository<E>>() as T;
            instance.Initialize(orgServiceFactory, context.UserId);
            return instance; 
          //  return container.GetInstance(typeof(IRepository<E>)) as T;
        }

    }
}
