using System;

namespace ConsoleApp1.Core
{
    // Custom exception specific to automation failures
    public class AutomationException : Exception
    {
        public AutomationException(string message)
            : base(message)
        {
        }
    }
}
