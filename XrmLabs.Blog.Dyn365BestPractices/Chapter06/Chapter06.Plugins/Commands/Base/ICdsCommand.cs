﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06.Plugins.Commands.Base
{
    public interface ICdsCommand
    {
        bool CanExecute();
        void Execute();
    }
}
