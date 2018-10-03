using FFTApp.Domain.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTApp.Infrastructure.Business.TestFrame.Test
{
    public interface ITest : ITestObject
    {
        int CountOfDUTsRow { get; set; }
        int CountOfDUTsColumn { get; set; }
        List<IDUT> TestList { get; set; }

        double WidthTab { get; set; }
        double HeightTab { get; set; }
    }
}
