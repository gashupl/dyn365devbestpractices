using Common.Entities;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02.Repositories
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : Entity
    {
        protected Dyn365ServiceContext serviceContext;
        protected IOrganizationService orgService;

        public RepositoryBase(IOrganizationService service)
        {
            this.orgService = service; 
            this.serviceContext = new Dyn365ServiceContext(service);
        }

        public void Create(T entity)
        {
            this.serviceContext.AddObject(entity);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T GetById(Guid id, string entityName)
        {
            return this.orgService.Retrieve(entityName, id, new Microsoft.Xrm.Sdk.Query.ColumnSet(true)).ToEntity<T>(); 
        }

        public void SaveChanges()
        {
            this.serviceContext.SaveChanges();
        }
    }
}
