using Chapter06.Plugins.Common;
using Chapter06.Plugins.Repositories;
using Chapter06.Plugins.Repositories.Base;

namespace Chapter06.Plugins.Commands.Base
{
    public class CdsCommandFactory 
    {
        protected ICdsServiceProvider serviceProvider { get; private set; }

        protected ICdsUnitOfWorkRepository cdsUnitOfWorkRepository { get; private set; }

        public CdsCommandFactory(ICdsServiceProvider serviceProvider,  ICdsUnitOfWorkRepository cdsUnitOfWorkRepository)
        {
            this.serviceProvider = serviceProvider;
            this.cdsUnitOfWorkRepository = cdsUnitOfWorkRepository ?? new CdsUnitOfWork(this.serviceProvider);
        }

        public ICdsCommand GetCommand<T>()  where T : CdsCommandBase, new()
        {
            T command = new T();
            command.Initialize(this.serviceProvider.Context, this.serviceProvider.TracingService, this.cdsUnitOfWorkRepository);
            return command;
        }
    }
}
