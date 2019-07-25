using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter04.Plugins.Repositories;
using Microsoft.Xrm.Sdk;

namespace Chapter04.Plugins.Repositories
{
    public interface IRepositoryFactory
    {
        T Get<E, T>() where E : Entity where T : RepositoryBase<E>; 
    }
}
