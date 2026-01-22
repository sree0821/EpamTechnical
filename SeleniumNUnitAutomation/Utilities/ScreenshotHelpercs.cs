using OpenQA.Selenium;
using System;
using System.IO;

namespace SeleniumNUnitAutomation.Utilities
{
    public static class ScreenshotHelper
    {
        public static void Capture(IWebDriver driver, string testName)
        {
            try
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                var file = Path.Combine(folder, $"{testName}_{DateTime.Now:yyyyMMdd_HHmmss}.png");
                screenshot.SaveAsFile(file);

                Logger.Info("Screenshot saved: " + file);
            }
            catch (Exception ex)
            {
                Logger.Error("Screenshot failed: " + ex.Message);
            }
        }
    }
}
