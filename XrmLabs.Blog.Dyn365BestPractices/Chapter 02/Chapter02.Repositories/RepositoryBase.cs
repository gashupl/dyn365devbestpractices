using Common.Entities;
using Microsoft.Xrm.Sdk;
using System;

namespace Chapter02.Repositories
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : Entity
    {
        protected Dyn365ServiceContext ServiceContext;
        protected IOrganizationService OrgService;

        public RepositoryBase(IOrganizationService service)
        {
            this.OrgService = service;
            this.ServiceContext = new Dyn365ServiceContext(service);
        }

        //Below commented code was use in the first example of generic constructor
        //public RepositoryBase()
        //{

        //}

        //public void Initialize(IOrganizationService service)
        //{
        //    this.OrgService = service;
        //    this.ServiceContext = new Dyn365ServiceContext(service);
        //}

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
