using System;
using IncubationProject.Base;

namespace IncubationProject.Core
{
    public class AccessModifiersTask : BrowserBase
    {
        // public - accessible everywhere
        public BrowserType Browser = BrowserType.Chrome;

        // private - accessible only inside this class
        private TestStatus _testStatus;

        // protected - accessible to derived classes
        protected string ApplicationUrl = "https://www.google.com";

        // internal - accessible within same project
        internal void ExecuteTest()
        {
            Console.WriteLine($"Browser selected: {Browser}");

            LaunchBrowser(ApplicationUrl);
            Console.WriteLine("Browser launched");

            PerformLoginValidation();

            Console.WriteLine($"Test Status: {_testStatus}");

            CloseBrowser();
            Console.WriteLine("Browser closed");
        }

        // private method - internal logic
        private void PerformLoginValidation()
        {
            bool isLoginSuccessful = true;

            if (isLoginSuccessful)
            {
                _testStatus = TestStatus.Passed;
            }
            else
            {
                _testStatus = TestStatus.Failed;
            }
        }
    }
}
