using FFTApp.Domain.TestData;
using FFTApp.Infrastructure.Business.TestFrame.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTApp.Business.TestFrame.Test
{
    public class Test : ITest
    {
       
        private static readonly string Avatar1Uri = @"/FFTApp.Business.TestFrame;component/Images/MC900432625.PNG";
        //private static readonly string Avatar1Uri = @"/Services.PersonService;component/Images/MC900432625.PNG";
        //private static readonly string Avatar2Uri = @"/Services.PersonService;component/Images/MC900433938.PNG";

        public string Error { get; set; }

        public bool Initialize()
        {           
            int i, j;           
            IDUT dut;

            this.CountOfDUTsRow = 10;
            this.CountOfDUTsColumn = 16;

            this.TestList = new List<IDUT>(this.CountOfDUTsRow * this.CountOfDUTsColumn);                                  
            for (j = 0; j < this.CountOfDUTsRow; j++)
            {
                for (i = 0; i < this.CountOfDUTsColumn; i++)
                {
                    dut = new DUT() { ID = (i + 1) + j * this.CountOfDUTsColumn };
                    dut.Image = Avatar1Uri;
                    TestList.Add(dut);
                }
            }


            return true;
        }

        public List<IDUT> TestList { get; set; }

        public int CountOfDUTsRow { get; set; }
        public int CountOfDUTsColumn { get; set; }

        public double WidthTab { get; set; }
        public double HeightTab { get; set; }
    }

}
