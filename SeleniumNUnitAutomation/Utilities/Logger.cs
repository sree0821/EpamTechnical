using log4net;
using log4net.Config;
using System.Reflection;

namespace SeleniumNUnitAutomation.Utilities
{
    public static class Logger
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static Logger()
        {
            XmlConfigurator.Configure(new FileInfo("Config/log4net.config"));
        }

        public static void Info(string message)
        {
            log.Info(message);
        }

        public static void Error(string message)
        {
            log.Error(message);
        }
    }
}
