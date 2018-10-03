using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTApp.Infrastructure.Business.TestFrame.Test
{ 
    public interface ITestObject
    {
        bool Initialize();
        string Error { get; set; }
    }
}
