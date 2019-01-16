using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace TestProjectWithUnityIoc.Utility.Ioc
{
    public class UnityConfig
    {
        private static readonly Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetUnityContainer()
        {
            return Container.Value;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            var module = (IContainerRegistrationModule<IUnityContainer>)Activator.CreateInstance(typeof(UnityRegistrationModule));
            module.Register(container);
        }
    }
}
