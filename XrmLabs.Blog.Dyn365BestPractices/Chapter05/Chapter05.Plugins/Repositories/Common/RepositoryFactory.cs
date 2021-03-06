﻿using Microsoft.Xrm.Sdk;
using System;
using SimpleInjector;

namespace Chapter05.Plugins.Repositories.Common
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private Container container; 

        public RepositoryFactory(Container container)
        {
            this.container = container;
        }
        public T Get<E, T>() where E : Entity where T : IRepository<E>
        {
            var context = container.GetInstance<IPluginExecutionContext>();
            var orgServiceFactory = container.GetInstance<IOrganizationServiceFactory>();
            var instance = (T)container.GetInstance(typeof(T));
            instance.Initialize(orgServiceFactory, context.UserId);
            return instance; 
        }

        public T Get<E, T>(Guid userId) where E : Entity where T : IRepository<E>
        {
            var context = container.GetInstance<IPluginExecutionContext>();
            var orgServiceFactory = container.GetInstance<IOrganizationServiceFactory>();
            var instance = (T)container.GetInstance(typeof(T));
            instance.Initialize(orgServiceFactory, userId);
            return instance;
        }
    }
}
