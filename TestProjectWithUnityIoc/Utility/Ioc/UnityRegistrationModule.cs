using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace TestProjectWithUnityIoc.Utility.Ioc
{
    public class UnityRegistrationModule : IContainerRegistrationModule<IUnityContainer>
    {
        public void Register(IUnityContainer container)
        {
            throw new NotImplementedException();
        }
    }
}
