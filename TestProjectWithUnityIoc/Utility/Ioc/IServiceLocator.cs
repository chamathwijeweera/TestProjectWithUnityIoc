using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectWithUnityIoc.Utility.Ioc
{
    public interface IServiceLocator
    {
        T Get<T>();
    }

    public interface IContainerRegistrationModule<T>
    {
        void Register(T container);
    }
}
