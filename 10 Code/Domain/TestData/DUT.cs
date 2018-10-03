using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTApp.Domain.TestData
{
    public class DUT : IDUT
    {
        public int ID { get; set; }

        
        public string Name
        {
            get
            {
                return $"DUT {this.ID.ToString()}";
            }
            set { }
        }

        public string Image{ get; set; }

    }
}
