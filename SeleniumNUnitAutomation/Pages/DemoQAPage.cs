using OpenQA.Selenium;
using SeleniumNUnitAutomation.Utilities;

namespace SeleniumNUnitAutomation.Pages
{
    public class DemoQAPage
    {
        private IWebDriver driver;

        public DemoQAPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Locators
        private By fullName = By.Id("userName");
        private By email = By.Id("userEmail");
        private By submitButton = By.Id("submit");

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");
        }

        public void FillForm(string name, string email)
        {
            driver.FindElement(By.Id("userName")).SendKeys(name);
            driver.FindElement(By.Id("userEmail")).SendKeys(email);
        }

        public void ScrollAndSubmit()
        {
            JavaScriptHelper.ScrollToBottom(driver);
            driver.FindElement(submitButton).Click();
        }

        public void ClickSubmitSafely()
        {
            try
            {
                driver.FindElement(submitButton).Click();
            }
            catch (StaleElementReferenceException)
            {
                driver.FindElement(submitButton).Click();
            }
        }

        public void SubmitForm()
        {
            // Sometimes button is not visible → scroll
            JavaScriptHelper.ScrollToBottom(driver);

            driver.FindElement(submitButton).Click();
        }
    }
}
