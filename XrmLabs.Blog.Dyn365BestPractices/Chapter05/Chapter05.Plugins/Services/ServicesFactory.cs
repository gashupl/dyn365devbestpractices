using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05.Plugins.Services
{
    public class ServicesFactory : IServicesFactory
    {
        private Container container;

        public ServicesFactory(Container container)
        {
            this.container = container;
        }
        public T Get<T>() where T : IService
        {
            return (T)this.container.GetInstance(typeof(T));
        }
    }
}
