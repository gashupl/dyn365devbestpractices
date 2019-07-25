using Microsoft.Xrm.Sdk;
using System;
using Chapter04.Plugins.Repositories;

namespace Chapter04.Plugins.Repositories
{
    public class RepositoryFactory : IRepositoryFactory
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
