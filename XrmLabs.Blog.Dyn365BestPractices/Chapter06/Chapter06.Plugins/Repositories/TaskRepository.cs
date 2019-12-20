using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter06.Plugins.Repositories.Base;
using Common.Entities;

namespace Chapter06.Plugins.Repositories
{
    public class TaskRepository : Repository<Task>, ITaskRepository
    {
    }
}
