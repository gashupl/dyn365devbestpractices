using System;
using Chapter06.Plugins.Common;
using Chapter06.Plugins.Repositories.Base;
using Common.Entities;
using Microsoft.Xrm.Sdk;
using SimpleInjector;

namespace Chapter06.Plugins.Repositories
{
    class CdsUnitOfWork : ICdsUnitOfWorkRepository
    {
        private readonly ICdsServiceProvider serviceProvider = null;
        Container container = new Container();

        public CdsUnitOfWork()
        {
            SetMapping();
        }

        public CdsUnitOfWork(ICdsServiceProvider serviceProvider) : this()
        {
            this.serviceProvider = serviceProvider;
        }

        private void SetMapping()
        {
            RegisterEntityRepository<ITaskRepository, Task, TaskRepository>();
            RegisterEntityRepository<ITeamRepository, Team, TeamRepository>();
        }

        public IRepository<E> GetRepositoryEntity<E>() where E : Entity, new()
        {
            return container.GetInstance<IRepository<E>>(); 
        }

        public E GetRepository<E>() where E : class
        {
            return container.GetInstance<E>(); 
        }

        private void RegisterEntityRepository<TRepoInterface, TEntityProxyClass, TRepoImplementation>()
            where TRepoInterface : IRepository<TEntityProxyClass>
            where TEntityProxyClass : Entity, new()
            where TRepoImplementation : TRepoInterface, new()
        {
            container.Register(typeof(TRepoInterface), typeof(TRepoImplementation));
            container.Register(typeof(IRepository<TEntityProxyClass>), typeof(TRepoImplementation));
        }
    }
}
