using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPSampleWPF.Models;
using MVPSampleWPF.Views;

namespace MVPSampleWPF.Presenters
{
    public class TestScriptPresenter
    {
        ITestScript iTestScriptView;

        public TestScriptPresenter(ITestScript iTestScript)
        {
            iTestScriptView = iTestScript;
        }

        public void SaveTest()
        {
            TestScript testScript = new TestScript();

            testScript.Title = iTestScriptView.Title;
            testScript.Author = iTestScriptView.Author;
            testScript.Description = iTestScriptView.Description;
            testScript.FilePath = iTestScriptView.FilePath;
            testScript.Browser = iTestScriptView.Browser;
            //testScript.TestSteps = iTestScriptView.TestSteps;

            testScript.Save();
        }
    }
}
