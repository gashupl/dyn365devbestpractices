using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter06.Plugins.Repositories;
using Chapter06.Plugins.Repositories.Base;
using Microsoft.Xrm.Sdk;

namespace Chapter06.Plugins.Commands.Base
{
    public abstract class CdsCommandBase : ICdsCommand
    {

        protected IPluginExecutionContext Context { get; set; }

        protected ITracingService TracingService { get; set; }

        //protected ICrmUnitOfWorkService CrmUnitOfWorkService { get; private set; }
        protected ICdsUnitOfWorkRepository CrmUnitOfWorkRepository { get; private set; }

        public abstract bool CanExecute();
        public abstract void Execute();

        public void Initialize(IPluginExecutionContext context, ITracingService tracingService, ICdsUnitOfWorkRepository unitOfWorkRepository)
        {
            this.Context = context;
            this.TracingService = tracingService;
            this.CrmUnitOfWorkRepository = unitOfWorkRepository;

        }
    }
}
