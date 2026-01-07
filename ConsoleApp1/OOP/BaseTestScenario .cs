using IncubationProject.Base;

namespace ConsoleApp1.OOP
{
    // Abstract class provides common automation logic
    public abstract class BaseTestScenario : BrowserBase, ITestScenario
    {
        protected string ApplicationUrl = "https://www.google.com";

        // Abstract method must be implemented by child classes
        public abstract void ExecuteTest();

        // Common reusable method
        protected void OpenApplication()
        {
            LaunchBrowser(ApplicationUrl);
        }
    }
}
