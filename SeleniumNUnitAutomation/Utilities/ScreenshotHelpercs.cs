using OpenQA.Selenium;
using System.IO;

namespace SeleniumNUnitAutomation.Utilities
{
    public static class ScreenshotHelper
    {
        public static void TakeScreenshot(IWebDriver driver, string name)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            File.WriteAllBytes($"{name}.png", screenshot.AsByteArray);
        }
    }
}
