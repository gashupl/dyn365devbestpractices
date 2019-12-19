using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter06.Plugins.Common;
using Microsoft.Xrm.Sdk;

namespace Chapter06.Plugins.Repositories
{
    class CdsUnitOfWorkRepository : ICdsUnitOfWorkRepository
    {
        private ICdsServiceProvider serviceProvider = null;

        public CdsUnitOfWorkRepository()
        {
            SetMapping();
        }

        public CdsUnitOfWorkRepository(ICdsServiceProvider serviceProvider) : this()
        {
            this.serviceProvider = serviceProvider;
        }

        private void SetMapping()
        {
            //Place your mappings here
        }


        public IRepository<E> GetRepositoryEntity<E>() where E : Entity, new()
        {
            throw new NotImplementedException();
        }

        public E GetRepository<E>()
        {
            throw new NotImplementedException();
        }
    }
}
