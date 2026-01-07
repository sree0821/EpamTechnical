using IncubationProject.Base;

namespace ConsoleApp1.Utilities
{
    public class LoggerTask : BrowserBase
    {
        private static string ApplicationUrl = "https://example.com";

        public void ExecuteTest()
        {
            try
            {
                Logger.Info("Launching browser");
                LaunchBrowser(ApplicationUrl);

                Logger.Info("Navigated to application URL");
                Logger.Info("Performing validation step");

                bool isValidationSuccessful = true;

                if (!isValidationSuccessful)
                {
                    Logger.Warn("Validation failed, proceeding with caution");
                }

                Logger.Info("Test execution completed successfully");
            }
            catch (Exception ex)
            {
                Logger.Error($"Test failed due to exception: {ex.Message}");
            }
            finally
            {
                Logger.Info("Closing browser");
                CloseBrowser();
            }
        }
    }
}
