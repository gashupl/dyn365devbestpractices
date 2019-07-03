using Chapter02.Repositories;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03.Plugins.Sample3
{
    public class RepositoryFactory
    {
        private IOrganizationService service;
        public RepositoryFactory(IOrganizationService service)
        {
            this.service = service;
        }
        public T Get<E, T>() where E : Entity where T : RepositoryBase<E>
        {
            var repository = (T)Activator.CreateInstance(typeof(T), this.service); 
            return repository;
        }

     
    }
}
