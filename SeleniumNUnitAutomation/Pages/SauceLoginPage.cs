using OpenQA.Selenium;
using SeleniumNUnitAutomation.Config;
using SeleniumNUnitAutomation.Utilities;

namespace SeleniumNUnitAutomation.Pages
{
    public class SauceLoginPage
    {
        private IWebDriver driver;

        public SauceLoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By username = By.Id("user-name");
        private By password = By.Id("password");
        private By loginBtn = By.Id("login-button");

        public void Navigate()
        {
            Logger.Info("Opening SauceDemo");
            driver.Navigate().GoToUrl(ConfigReader.SauceUrl);
        }

        public void Login(string user, string pass)
        {
            Logger.Info("Logging in");
            WaitHelper.WaitForElement(driver, username).SendKeys(user);
            WaitHelper.WaitForElement(driver, password).SendKeys(pass);
            WaitHelper.WaitForElement(driver, loginBtn).Click();
        }
    }
}
