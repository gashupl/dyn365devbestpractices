﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entities;

namespace Chapter04.Plugins.Services
{
    public interface IOpportunityTestService
    {
        void DoSomething(Opportunity opportunity); 
    }
}
