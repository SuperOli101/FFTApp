using FFTApp.Domain.TestData;
using FFTApp.Infrastructure.Business.TestFrame.Test;
using Microsoft.Practices.Unity;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FFTApp.UI.ViewModels
{
    public class TestMainViewModel : BindableBase
    {
        public ITest Test { get; set; }
        public TestMainViewModel(ITest Test)
        {
            this.Test = Test;
        }
        private string name = "Oliver Gebert";
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }        

        private ObservableCollection<IDUT> duts;
        public ObservableCollection<IDUT> DUTs
        {
            get
            {
                return duts;
            }
            set { SetProperty(ref duts, value); }
        }

        public void LoadedTab(object sender, EventArgs arg)
        {
            double onePartSize;
            onePartSize = this.Test.WidthTab / (this.Test.CountOfDUTsColumn + 1);
            this.WidthImage = (int)(onePartSize + onePartSize * 0.4 / this.Test.CountOfDUTsColumn);
            onePartSize = this.Test.HeightTab / (this.Test.CountOfDUTsRow + 1);
            this.HeightImage = (int)(onePartSize + onePartSize * 0.4 / this.Test.CountOfDUTsRow);

            //this.WidthImage = (int)(this.Test.WidthTab / this.Test.CountOfDUTsColumn * 0.99);
            //this.HeightImage = (int)(this.Test.HeightTab / this.Test.CountOfDUTsRow * 0.99);

            this.DUTs = new ObservableCollection<IDUT>(Test.TestList);
        }
        public void ChangedSizeOfTab(object sender, EventArgs arg)
        {
            double onePartSize;
            onePartSize = this.Test.WidthTab / (this.Test.CountOfDUTsColumn + 1);
            this.WidthImage = (int)(onePartSize + onePartSize * 0.4 / this.Test.CountOfDUTsColumn);
            onePartSize = this.Test.HeightTab / (this.Test.CountOfDUTsRow + 1);
            this.HeightImage = (int)(onePartSize + onePartSize * 0.4 / this.Test.CountOfDUTsRow);
            //RoutedEventArgs args = (RoutedEventArgs)arg;


            //SetProperty(ref this.heightImage, height, nameof(this.HeightImage));
            //SetProperty(ref this.widthImage, width, nameof(this.WidthImage));
            //((RoutedEventArgs)args).Handled = true;
            
        }

        private double widthImage = 75;
        public double WidthImage
        {
            get
            {
                return widthImage;
            }
            set
            {
                if (this.widthImage != value)
                    SetProperty(ref widthImage, value);

                //this.Name = width.ToString("#.##");
            }
        }
        private double heightImage = 75;
        public double HeightImage
        {
            get
            {
                return heightImage;
            }
            set
            {
                if (this.heightImage != value)
                    SetProperty(ref heightImage, value);
                //this.Name = width.ToString("#.##");
            }
        }
    }
}
