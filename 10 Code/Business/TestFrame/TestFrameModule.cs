using FFTApp.Infrastructure.Business.TestFrame.Test;
using FFT = FFTApp.Business.TestFrame.Test;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTApp.Business.TestFrame
{
    [Module(ModuleName = "TestFrame")]
    public class TestFrameModule : IModule
    {
        IUnityContainer container;
        public TestFrameModule(IUnityContainer container) 
        {
            this.container = container;
           
        }
        public void Initialize()
        {
            this.container.RegisterType<ITest, FFT.Test>(new ContainerControlledLifetimeManager());
        }
    }
}
