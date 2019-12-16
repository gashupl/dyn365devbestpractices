using Common.Entities;
using Microsoft.Xrm.Sdk;
using System;

namespace Chapter05.Plugins.Repositories.Common
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : Entity
    {
        protected Dyn365ServiceContext ServiceContext;
        protected IOrganizationService OrgService;

        public void Initialize(IOrganizationServiceFactory service, Guid userId)
        {
            this.OrgService = service.CreateOrganizationService(userId);
            this.ServiceContext = new Dyn365ServiceContext(this.OrgService);
        }

        public void Create(T entity)
        {
            this.ServiceContext.AddObject(entity);
        }

        public T GetById(Guid id)
        {
            var entityName = typeof(T).Name; 
            return this.OrgService.Retrieve(entityName, id, new Microsoft.Xrm.Sdk.Query.ColumnSet(true)).ToEntity<T>(); 
        }

        public void SaveChanges()
        {
            this.ServiceContext.SaveChanges();
        }

        public void Dispose()
        {
            ServiceContext.Dispose();
        }


    }
}
