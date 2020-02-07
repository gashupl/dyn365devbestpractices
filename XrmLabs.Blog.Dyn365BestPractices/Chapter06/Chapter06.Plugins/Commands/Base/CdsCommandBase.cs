using Chapter06.Plugins.Repositories.Base;
using Microsoft.Xrm.Sdk;

namespace Chapter06.Plugins.Commands.Base
{
    public abstract class CdsCommandBase : ICdsCommand
    {

        protected IPluginExecutionContext Context { get; set; }

        protected ITracingService TracingService { get; set; }

        protected ICdsRepositoryFactory CdsRepositoryFactory { get; private set; }

        protected Entity TargetEntity
        {
            get { return Context?.InputParameters["Target"] as Entity;  }
        }

        public abstract bool CanExecute();
        public abstract void Execute();

        public void Initialize(IPluginExecutionContext context, ITracingService tracingService, ICdsRepositoryFactory repositoryFactory)
        {
            this.Context = context;
            this.TracingService = tracingService;
            this.CdsRepositoryFactory = repositoryFactory;

        }
    }
}
