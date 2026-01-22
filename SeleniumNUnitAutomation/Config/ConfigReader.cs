using Microsoft.Extensions.Configuration;

namespace SeleniumNUnitAutomation.Config
{
    public static class ConfigReader
    {
        private static readonly IConfiguration? config;

        static ConfigReader()
        {
            config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public static string Browser => config["Browser"];
        public static string GoogleUrl => config["GoogleUrl"];
        public static string DemoQAUrl => config["DemoQAUrl"];
        public static string SauceUrl => config["SauceUrl"];
        public static int ImplicitWait => int.Parse(config["ImplicitWait"]);
        public static string FlipkartUrl => config["FlipkartUrl"];
        public static string DemoSiteUrl => config["DemoSiteForAutomation"];
        public static string DemoQAMainUrl => config["DemoQAMainUrl"];
    }
}
