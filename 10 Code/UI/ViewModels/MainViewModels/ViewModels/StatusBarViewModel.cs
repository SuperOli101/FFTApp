using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTApp.UI.ViewModels
{
    public class StatusBarViewModel : BindableBase
    {
        private string message = "Ready";
        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }        
    }
}
