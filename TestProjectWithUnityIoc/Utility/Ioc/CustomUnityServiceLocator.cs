﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace TestProjectWithUnityIoc.Utility.Ioc
{
    public class CustomUnityServiceLocator : DependencyInjectionServiceLocator<IUnityContainer>
    {
        public CustomUnityServiceLocator(IUnityContainer container) : base(container)
        { }

        protected override T Get<T>(IUnityContainer container)
        {
            return this.Container.Resolve<T>();
        }
    }
}
