using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumNUnitAutomation.Utilities
{
    public static class ActionHelper
    {
        public static void Hover(IWebDriver driver, IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Perform();
        }

        public static void RightClick(IWebDriver driver, IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.ContextClick(element).Perform();
        }
    }
}
