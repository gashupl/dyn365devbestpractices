using System;
using Chapter06.Plugins.Common;
using Chapter06.Plugins.Repositories.Base;
using Common.Entities;
using Microsoft.Xrm.Sdk;

namespace Chapter06.Plugins.Repositories
{
    class CdsUnitOfWorkRepository : ICdsUnitOfWorkRepository
    {
        private readonly ICdsServiceProvider serviceProvider = null;

        public CdsUnitOfWorkRepository()
        {
            SetMapping();
        }

        public CdsUnitOfWorkRepository(ICdsServiceProvider serviceProvider) : this()
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
            throw new NotImplementedException();
        }

        public E GetRepository<E>()
        {
            throw new NotImplementedException();
        }

        private void RegisterEntityRepository<RepoInterface, EntityProxyClass, RepoImplementation>()
            where RepoInterface : IRepository<EntityProxyClass>
            where EntityProxyClass : Entity, new()
            where RepoImplementation : RepoInterface, new()
        {
            //TODO: Implement registration with SimpleInjector
            throw new NotImplementedException(); 
        }
    }
}
