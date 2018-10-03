using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTApp.UI.ViewModels.Models.PartProductionDB
{
    public class RelationSoftwareIdToPartNumber : IRelationSoftwareIdToPartNumber
    {
        public int SoftwareId { get; set; }
        public string PartNumber { get; set; }
    }
}
