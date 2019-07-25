using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter04.Plugins.Repositories;

namespace Chapter04.Plugins.Services
{
    public abstract class ServiceBase
    {
        protected IRepositoryFactory repositoryFactory; 
        public ServiceBase(IRepositoryFactory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory; 
        }
    }
}
