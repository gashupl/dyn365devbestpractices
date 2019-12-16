using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;

namespace Chapter05.Plugins.Dependencies
{
    public interface IDependencyLoader
    {
        void RegisterDependencies(Container container);
    }
}
