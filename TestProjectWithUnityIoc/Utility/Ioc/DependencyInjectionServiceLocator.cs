using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectWithUnityIoc.Utility.Ioc
{
    public abstract class DependencyInjectionServiceLocator<TContainer> : IServiceLocator
    {
        protected TContainer Container { get; private set; }

        protected DependencyInjectionServiceLocator(TContainer container)
        {
            Container = container;
        }

        public virtual T Get<T>()
        {
            return Get<T>(Container);
        }

        protected abstract T Get<T>(TContainer container);
    }
}
