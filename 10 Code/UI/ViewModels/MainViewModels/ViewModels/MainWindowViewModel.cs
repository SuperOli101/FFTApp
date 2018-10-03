using FFTApp.Infrastructure.Business.TestFrame.Test;
using Microsoft.Practices.Unity;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;

namespace FFTApp.UI.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        IUnityContainer container;
        public ITest Test { get; set; }
        public MainWindowViewModel(/*ITest Test*/IUnityContainer container)
        {
            this.container = container;
            this.Test = this.container.Resolve<ITest>();

            //this.Test = Test;     
        }
        private string title = "Oliver Gebert from MainWindowViewModel";
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        private double widthTab = -1;
        public double WidthTab
        {
            get
            {
                return widthTab;
            }
            set
            {
                widthTab = value;
                //this.WidthImage = value

                //SetProperty(ref width, value);
                //this.Name = width.ToString("#.##");
            }
        }
        private double heightTab = -1;
        public double HeightTab
        {
            get
            {
                return heightTab;
            }
            set
            {
                heightTab = value;

                //SetProperty(ref width, value);
                //this.Name = width.ToString("#.##");
            }
        }
        

 
        public void ChangedSizeOfTab(object sender, EventArgs arg)
        {

            //RoutedEventArgs args = (RoutedEventArgs)arg;


            //SetProperty(ref this.heightImage, height, nameof(this.HeightImage));
            //SetProperty(ref this.widthImage, width, nameof(this.WidthImage));
            //((RoutedEventArgs)args).Handled = true;
            this.Test.HeightTab = this.HeightTab;
            this.Test.WidthTab = this.WidthTab;
        }


        public void LoadedTab(object sender, EventArgs arg)
        {

            this.Test.HeightTab = this.HeightTab;
            this.Test.WidthTab = this.WidthTab;

            //System.Windows.Controls.StackPanel stack = (System.Windows.Controls.StackPanel)sender;
            //RoutedEventArgs args = (RoutedEventArgs)arg;
            //stack.Size
            this.Test.Initialize();
            //this.heightImage = (int)(this.HeightTab / this.Test.CountOfDUTsRow * 0.99);
            //this.widthImage = (int)(this.WidthTab / this.Test.CountOfDUTsColumn * 0.99);
           

        }
    }
}
