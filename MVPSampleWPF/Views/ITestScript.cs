using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPSampleWPF.Views
{
    public interface ITestScript
    {
        string Title { get; set; }
        string Author { get; set; }
        string Description { get; set; }
        string FilePath { get; set; }
        string Browser { get; set; }    
        //Dictionary<int, string> TestSteps { get; set; }


    }
}
