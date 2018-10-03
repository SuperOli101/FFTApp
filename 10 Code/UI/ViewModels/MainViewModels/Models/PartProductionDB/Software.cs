using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTApp.UI.ViewModels.Models.PartProductionDB
{
    public class Software : ISoftware
    {
        public int? SoftwareId { get; set; }
        public int? ParentSoftwareId { get; set; }
        public int? ProductionCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public int? ProductionSystemNumberId { get; set; }
    }
}
