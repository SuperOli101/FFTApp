using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FFTApp.UI.ViewModels
{
    public class ToolBarViewModel : BindableBase
    {
        public ToolBarViewModel()
        {
            SaveCommand = new DelegateCommand(Save, CanSave);

            //SaveCommand.RaiseCanExecuteChanged();
        }

        private bool CanSave()
        {
            return true;
        }

        private void Save()
        {
            MessageBox.Show("Oli");
        }

        public DelegateCommand SaveCommand { get; set; }
    }
}
