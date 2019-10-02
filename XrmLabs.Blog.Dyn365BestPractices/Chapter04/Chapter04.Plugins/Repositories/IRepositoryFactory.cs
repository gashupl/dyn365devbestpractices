using System;
using Microsoft.Xrm.Sdk;

namespace Chapter04.Plugins.Repositories
{
    public interface IRepositoryFactory
    {
        T Get<E, T>() where E : Entity where T : IRepository<E>;

        T Get<E, T>(Guid userId) where E : Entity where T : IRepository<E>; 
    }
}
