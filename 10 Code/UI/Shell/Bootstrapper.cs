using Microsoft.Practices.Unity;
using Prism.Unity;
using System.Windows;
using Prism.Modularity;
using FFTApp.UI.Shell.Views;
using System;
using System.Reflection;


namespace FFTApp.UI
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<ShellView>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            //ModulePath = @".\Views"
            DirectoryModuleCatalog dirCat = new DirectoryModuleCatalog() { ModulePath = @"." };


            //dirCat.Load();
            //dirCat.Initialize();

            

            return dirCat;
        }
        
        
        protected override void InitializeModules()
        {
           
            

            //string name;
            //int i = 0;
            //ModuleInfo[] modulInfo = new ModuleInfo[3];
            //foreach (var modul in this.ModuleCatalog.Modules)
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

            //    modulInfo[1].DependsOn = dependency;
            //}

            base.InitializeModules();
        }

        protected override void ConfigureModuleCatalog()
        {

            //var mainWindowViewModelType = typeof(MainViewModelsModule);
            //this.ModuleCatalog.AddModule(
            //    new ModuleInfo()
            //    {
            //        ModuleName = mainWindowViewModelType.Name,
            //        ModuleType = mainWindowViewModelType.AssemblyQualifiedName,
            //        InitializationMode = InitializationMode.WhenAvailable
            //    });

            //var dependency = new System.Collections.ObjectModel.Collection<string>();
            //dependency.Add(mainWindowViewModelType.Name);
            //var mainWindowViewType = typeof(MainViewsModule);
            //this.ModuleCatalog.AddModule(
            //    new ModuleInfo()
            //    {
            //        //DependsOn = dependency,            
            //        ModuleName = mainWindowViewType.Name,
            //        ModuleType = mainWindowViewType.AssemblyQualifiedName,
            //        InitializationMode = InitializationMode.WhenAvailable
            //    });


        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
      
            Prism.Mvvm.ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver(
                (viewType) =>
                {
                    string viewAssemblyName;
                    string viewModelName;
                    Type viewModelType;
                    string viewName = viewType.FullName;
                    if (viewName.Contains(".Shell."))
                    {
                        //FFTApp.UI.Shell.Views.MainWindow
                        viewName = viewName.Replace(".Views.", ".ViewModels.");
                        viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                        viewModelName = $"{viewName}Model, {viewAssemblyName}";
                        //FFTApp.UI.Shell.ViewModels.MainWindowViewModel
                        viewModelType = Type.GetType(viewModelName);
                    }
                    else if (viewName.Contains(".UI.Views."))
                    {


                        viewModelName = "";
                        viewModelName = viewName.Replace(".UI.Views.", ".UI.ViewModels.");
                        viewModelName = viewModelName + "Model";
                        viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                        string[] arrayNamespace = viewAssemblyName.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (arrayNamespace.Length == 4)
                        {
                            arrayNamespace = arrayNamespace[0].Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
                            if (arrayNamespace.Length == 4)
                            {
                                arrayNamespace[2] = arrayNamespace[2].Replace("Views", "ViewModels");
                                arrayNamespace[3] = arrayNamespace[3].Replace("Views", "ViewModels");
                                viewAssemblyName = $"{arrayNamespace[0]}.{arrayNamespace[1]}.{arrayNamespace[2]}.{arrayNamespace[3]}";

                                viewModelName = $"{viewModelName}, {viewAssemblyName}" + ", Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";
                            }
                        }

                        viewModelType = Type.GetType(viewModelName);
                    }
                    else
                    {
                        //FFTApp.UI.Views.MainWindowView
                        viewName = viewName.Replace(".Views.", ".ViewModels.");
                        viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                        //FFTApp.UI.Views.MainViews
                        viewAssemblyName = viewAssemblyName.Replace("Views", "ViewModels");
                        viewModelName = $"{viewName}Model, {viewAssemblyName}";
                        //FFTApp.UI.ViewModels.MainWindowViewModel FFTApp.UI.ViewModels.MainViewModels.dll
                        viewModelType = Type.GetType(viewModelName);
                    }


                    
                    //Sample of Locator
                    //if (DesignerProperties.GetIsInDesignMode(d)) return;
                    //var viewType = d.GetType();
                    //var viewTypeName = viewType.FullName;
                    //var viewModelTypeName = viewType + "Model";
                    //var viewModelType = Type.GetType(viewModelTypeName);
                    //var viewModel = Activator.CreateInstance(viewModelType);
                    //((FrameworkElement)d).DataContext = viewModel;

                    return viewModelType;
                });
        }


    }
}
