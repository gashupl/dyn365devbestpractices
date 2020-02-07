using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chapter06.Plugins.Repositories.Base;
using Common.Entities;

namespace Chapter06.Plugins.Repositories
{
    public interface ITeamRepository : IRepository<Team>
    {
        Team GetSalesTeam(); 
    }
}
