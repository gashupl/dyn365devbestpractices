using Chapter06.Plugins.Common;
using Chapter06.Plugins.Repositories;
using Chapter06.Plugins.Repositories.Base;

namespace Chapter06.Plugins.Commands.Base
{
    public class CdsCommandFactory 
    {
        protected ICdsServiceProvider serviceProvider { get; private set; }

        protected ICdsRepositoryFactory cdsRepositoryFactory { get; private set; }

        public CdsCommandFactory(ICdsServiceProvider serviceProvider, ICdsRepositoryFactory cdsRepositoryFactory)
        {
            this.serviceProvider = serviceProvider;
            this.cdsRepositoryFactory = cdsRepositoryFactory ?? new CdsRepositoryFactory(this.serviceProvider);
        }

        public ICdsCommand GetCommand<T>()  where T : CdsCommandBase, new()
        {
            T command = new T();
            command.Initialize(this.serviceProvider.Context, this.serviceProvider.TracingService, this.cdsRepositoryFactory);
            return command;
        }
    }
}
