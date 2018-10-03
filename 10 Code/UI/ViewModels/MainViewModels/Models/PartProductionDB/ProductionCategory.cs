using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTApp.UI.ViewModels.Models.PartProductionDB
{
    public class ProductionCategory : IProductionCategory
    {
        public int? ProductionCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
