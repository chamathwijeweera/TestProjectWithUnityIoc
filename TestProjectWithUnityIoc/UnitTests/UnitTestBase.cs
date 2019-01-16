using System.Xml;
using System.Xml.Linq;
using TestProjectWithUnityIoc.Utility.Ioc;
using Unity;

namespace TestProjectWithUnityIoc.UnitTests
{
    public abstract class UnitTestBase : TestBase
    {
        private static IUnityContainer _unityContainer = null;
        private static IServiceLocator _serviceLocator = null;

        private static IUnityContainer UnityContainer
        {
            get { return _unityContainer ?? (_unityContainer = UnityConfig.GetUnityContainer()); }
        }

        private static IServiceLocator ServiceLocator
        {
            get { return _serviceLocator ?? (_serviceLocator = UnityContainer.Resolve<IServiceLocator>()); }
        }

        protected TService GetService<TService>()
        {
            return ServiceLocator.Get<TService>();
        }

        //Use this attribute [TestInitialize]
        public abstract void TestInitialization();

        //Use this attribute [TestCleanup]
        public abstract void TestCleanup();
    }
}
