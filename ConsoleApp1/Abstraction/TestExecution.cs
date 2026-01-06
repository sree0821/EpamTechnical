using ConsoleApp1.Abstraction;

namespace IncubationProject.Tests
{
    public class TestExecution
    {
        private readonly BrowserDriver _driver;

        public TestExecution(BrowserDriver driver)
        {
            _driver = driver;
        }

        public void RunTest()
        {
            _driver.LaunchBrowser();
            _driver.NavigateToUrl("https://google.com");

            Console.WriteLine("Test executed successfully.");

            _driver.CloseBrowser();
        }
    }
}