using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTApp.UI.ViewModels.Models.PartProductionDB
{
    public class Part : IPart
    {
        public string Number { get; set; }
        public string Description { get; set; }
    }
}
