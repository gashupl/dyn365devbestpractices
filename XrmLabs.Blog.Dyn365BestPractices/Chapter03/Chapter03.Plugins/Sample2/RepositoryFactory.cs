using Chapter02.Repositories;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03.Plugins.Sample2
{
    class RepositoryFactory
    {
        private IOrganizationService service;
        public RepositoryFactory(IOrganizationService service)
        {
            this.service = service;
        }
        public T Get<E, T>() where E : Entity  where T: IRepository<E>, new() 
        {
            throw new NotImplementedException(); 
           // return new T(this.service); 
        }
    }
}
