using OpenQA.Selenium;

namespace ReqnrollProject.Pages
{
    public class CheckoutPage
    {
        private IWebDriver driver;

        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By firstName = By.Id("first-name");
        private By lastName = By.Id("last-name");
        private By postalCode = By.Id("postal-code");
        private By continueBtn = By.Id("continue");
        private By finishBtn = By.Id("finish");
        private By successMsg = By.ClassName("complete-header");

        public void EnterDetailsAndContinue()
        {
            driver.FindElement(firstName).SendKeys("Test");
            driver.FindElement(lastName).SendKeys("User");
            driver.FindElement(postalCode).SendKeys("682001");
            driver.FindElement(continueBtn).Click();
        }

        public bool IsOrderCompleted()
        {
            driver.FindElement(finishBtn).Click();
            return driver.FindElement(successMsg).Displayed;
        }
    }
}
