using OpenQA.Selenium;

namespace SeleniumNUnitAutomation.Pages
{
    public class GooglePage
    {
        private readonly IWebDriver driver;

        public GooglePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By searchBox = By.Name("q");

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        public void Search(string text)
        {
            driver.FindElement(searchBox).SendKeys(text + Keys.Enter);
        }

        public string GetTitle()
        {
            return driver.Title;
        }
    }
}
