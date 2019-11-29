using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entities;

namespace Chapter05.Plugins.Services
{
    public interface IOpportunityService : IService
    {
        void DoSomething(Contact contact); 
    }
}
