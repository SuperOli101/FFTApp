using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTApp.UI.ViewModels
{
    [Module(ModuleName = "MainViewModels")]
    [ModuleDependency("TestFrame")]
    public class MainViewModelsModule : IModule
    {
        IRegionManager regionManager;
        IUnityContainer container;
        //IModuleCatalog moduleCatalog;
        public MainViewModelsModule(IRegionManager regionManager, IUnityContainer container) //, IModuleCatalog moduleCatalog
        {
            this.regionManager = regionManager;
            this.container = container;
            //this.moduleCatalog = moduleCatalog;

        }
        public void Initialize()
        {
            //this.container.RegisterType<>
            //var mainWindowViewModelType = typeof(MainWindowViewModel);


            //View Injection
            //var vm = container.Resolve<FilterViewModel>();
            //regionManager.Regions[""].Add();


            this.container.RegisterType<StatusBarViewModel>();
        }
    }
}
