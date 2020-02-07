using System;
using Chapter06.Plugins.Common;
using Chapter06.Plugins.Repositories.Base;
using Common.Entities;
using Microsoft.Xrm.Sdk;
using SimpleInjector;

namespace Chapter06.Plugins.Repositories
{
    class CdsRepositoryFactory : ICdsRepositoryFactory
    {
        private readonly ICdsServiceProvider serviceProvider = null;
        Container container = new Container();


        public CdsRepositoryFactory(ICdsServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            SetMapping();
        }

        private void SetMapping()
        {
            container.Register<ITeamRepository>(() => new TeamRepository(this.serviceProvider));
            container.Register<ITaskRepository>(() => new TaskRepository(this.serviceProvider)); 
        }

        public IRepository<E> GetRepositoryEntity<E>() where E : Entity, new()
        {
            return container.GetInstance<IRepository<E>>(); 
        }

        public E GetRepository<E>() where E : class
        {
            return container.GetInstance<E>(); 
        }

    }
}
