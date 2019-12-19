using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;

namespace Chapter06.Plugins.Repositories
{
    public interface ICdsUnitOfWorkRepository
    {
        IRepository<E> GetRepositoryEntity<E>() where E : Entity, new();

        E GetRepository<E>();

    }
}
