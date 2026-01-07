using System;

namespace ConsoleApp1.Utilities
{
    public static class Logger
    {
        public static void Info(string message)
        {
            Console.WriteLine($"[INFO] {DateTime.Now} - {message}");
        }

        public static void Warn(string message)
        {
            Console.WriteLine($"[WARN] {DateTime.Now} - {message}");
        }

        public static void Error(string message)
        {
            Console.WriteLine($"[ERROR] {DateTime.Now} - {message}");
        }
    }
}
