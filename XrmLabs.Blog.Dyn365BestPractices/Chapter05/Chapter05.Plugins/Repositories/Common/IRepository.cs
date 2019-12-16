using Microsoft.Xrm.Sdk;
using System;

namespace Chapter05.Plugins.Repositories.Common
{
    public interface IRepository<T> where T: Entity
    {
        void Initialize(IOrganizationServiceFactory service, Guid userId); 

        T GetById(Guid id);

        void Create(T entity);

        void SaveChanges();

        void Dispose();
    }
}
