using OpenQA.Selenium;

namespace SeleniumNUnitAutomation.Utilities
{
    public static class JavaScriptHelper
    {
        public static void ScrollToBottom(IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver)
                .ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }

        public static void ClickUsingJs(IWebDriver driver, IWebElement element)
        {
            ((IJavaScriptExecutor)driver)
                .ExecuteScript("arguments[0].click();", element);
        }
    }
}
