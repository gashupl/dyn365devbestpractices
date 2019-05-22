using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02.Repositories
{
    public interface IRepository<T> where T: Entity
    {
        T GetById(Guid id, string entityName);

        void Create(T entity);

        void SaveChanges();

        void Dispose();
    }
}
