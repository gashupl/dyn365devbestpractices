using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;

namespace Chapter06.Plugins.Repositories.Base
{
    public interface IRepository<E> : IRepositoryBase where E : Entity
    {
        Guid Create(E entity);

        void Delete(Guid id);

        IList<E> GetAllForJoin(Func<E, bool> predicate);

        IList<E> GetByAttribute(string attributeName, object value, Func<E, E> selector, int? limitResult = 50);

        E GetById(Guid id, Func<E, E> selector = null);

        E GetById(EntityReference id, Func<E, E> selector = null);

        void Update(E entity);

        void Upsert(E entity);

        void SaveChanges(); 

    }
}
