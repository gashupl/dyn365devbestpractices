﻿using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04.Plugins.Repositories
{
    public interface IRepository<T> where T: Entity
    {
        void Initialize(IOrganizationServiceFactory service, Guid userId); 

        T GetById(Guid id);

        void Create(T entity);

        void SaveChanges();

        void Dispose();
    }
}
