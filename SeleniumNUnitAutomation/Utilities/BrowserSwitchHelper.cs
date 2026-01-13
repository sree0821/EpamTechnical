using OpenQA.Selenium;

namespace SeleniumNUnitAutomation.Utilities
{
    public static class BrowserSwitchHelper
    {
        // Handle alert
        public static void AcceptAlert(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Accept();
        }

        public static void DismissAlert(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Dismiss();
        }

        public static string GetAlertText(IWebDriver driver)
        {
            return driver.SwitchTo().Alert().Text;
        }

        // Handle frames
        public static void SwitchToFrame(IWebDriver driver, int index)
        {
            driver.SwitchTo().Frame(index);
        }

        public static void SwitchToDefaultContent(IWebDriver driver)
        {
            driver.SwitchTo().DefaultContent();
        }

        // Handle windows
        public static void SwitchToNewWindow(IWebDriver driver)
        {
            var windows = driver.WindowHandles;
            driver.SwitchTo().Window(windows[windows.Count - 1]);
        }
    }
}
