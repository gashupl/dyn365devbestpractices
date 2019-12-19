using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter06.Plugins.Common;
using Chapter06.Plugins.Repositories;
using Microsoft.Xrm.Sdk;

namespace Chapter06.Plugins.Commands
{
    public class CdsCommandFactory<E> where  E: Entity 
    {
        private ICdsServiceProvider serviceProvider;
        private ICdsUnitOfWorkRepository cdsUnitOfWorkRepository { get; set; }

        public CdsCommandFactory(ICdsServiceProvider serviceProvider,  ICdsUnitOfWorkRepository cdsUnitOfWorkRepository)
        {
            this.serviceProvider = serviceProvider;
            this.cdsUnitOfWorkRepository = cdsUnitOfWorkRepository == null ? new CdsUnitOfWorkRepository(this.serviceProvider) : cdsUnitOfWorkRepository;
        }

        public ICdsCommand GetCommand<T>()  where T : CdsCommandBase, new()
        {
            T command = new T();
            command.Initialize(this.serviceProvider.Context, this.serviceProvider.TracingService, this.cdsUnitOfWorkRepository);
            return command;
        }
    }
}
