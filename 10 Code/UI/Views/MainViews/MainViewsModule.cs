using Microsoft.Practices.Unity;//Microsoft.Practices.Unity.dll
using Prism.Modularity;//Prism.Wpf.dll
using Prism.Regions;//Prism.Wpf.dll
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFTApp.UI.Infrastructure.Regions;
using FFTApp.UI.Views;

namespace FFTApp.UI.ViewModels
{
    [Module(ModuleName = "MainViews")]
    public class MainViewsModule : IModule
    {
        IRegionManager regionManager;
        IUnityContainer container;

        //IModuleCatalog moduleCatalog;
        //, IModuleCatalog moduleCatalog
        public MainViewsModule(IRegionManager regionManager, IUnityContainer container)
        {
            this.regionManager = regionManager;
            this.container = container;

           // this.moduleCatalog = moduleCatalog;

        }
        public void Initialize()
        {


            //int i = 0;
            //string name;
            //ModuleInfo[] modulInfo = new ModuleInfo[3];
            //foreach (var modul in this.moduleCatalog.Modules)
            //{
            //    i++;
            //    modulInfo[i - 1] = modul;
            //    name = modul.ModuleName;
            //}
            //if (i == 0)
            //    name = "";
            //else
            //{
            //    var dependency = new System.Collections.ObjectModel.Collection<string>();
            //    dependency.Add(modulInfo[0].ModuleName);

            //   modulInfo[1].DependsOn = dependency;
            //}


            //this.container.RegisterType<MainWindowView>();
            //this.container.RegisterType<IMainWindowView, MainWindowView>();
            //this.regionManager.RegisterViewWithRegion(RegionNames.ShellContentRegion, typeof(MainWindowView));


            //View Discovery
            this.regionManager.RegisterViewWithRegion(RegionNames.ContentRegionShell, typeof(MainWindowView));           

            this.regionManager.RegisterViewWithRegion(RegionNames.ContentRegionStatusBar, typeof(StatusBarView));
            this.regionManager.RegisterViewWithRegion(RegionNames.ContentRegionToolBar, typeof(ToolBarView));


            IRegion region = this.regionManager.Regions[RegionNames.ContentRegionTab];
            var view = this.container.Resolve<TestMainView>();
            region.Add(view);
            region.Activate(view);

            //view = this.container.Resolve<TestMainView>();
            //region.Add(view);
           

            //this.regionManager.RegisterViewWithRegion(RegionNames.ContentRegionTab, typeof(TestMainView));




            //View Injection
            //var vm = container.Resolve<FilterViewModel>();
            //regionManager.Regions[RegionNames.FilterContentRegion].Add();
            //Activate/Deactivate View 

            //FilterView view = new FilterView();
            //IRegion region = regionManager.Regions[RegionNames.FilterContentRegion];
            //region.Add(view);
            //region.Activate(view);
            //region.Deactivate(view);
            //region.ActiveViews[]; //Gezting active views
        }
    }
}
