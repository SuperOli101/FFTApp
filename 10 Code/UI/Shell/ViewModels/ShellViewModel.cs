using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTApp.UI.Shell.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        public ShellViewModel()
        {

        }

        private string _title = FFTApp.UI.Shell.Properties.Resources.TitleShell;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}
