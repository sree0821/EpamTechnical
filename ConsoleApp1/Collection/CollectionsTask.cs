using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1.Collection
{
    public class CollectionsTask
    {
        public void Execute()
        {
            List<string> testCases = new List<string>
            {
                "LoginTest",
                "SearchTest",
                "LogoutTest"
            };

            Console.WriteLine("List<T> contents:");
            foreach (var test in testCases)
            {
                Console.WriteLine(test);
            }

            ArrayList mixedData = new ArrayList
            {
                "Chrome",
                5,
                true
            };

            Console.WriteLine("\nArrayList contents:");
            foreach (var item in mixedData)
            {
                Console.WriteLine(item);
            }

            Dictionary<string, string> testData = new Dictionary<string, string>
            {
                { "username", "admin" },
                { "password", "admin123" }
            };

            Console.WriteLine("\nDictionary contents:");
            foreach (var data in testData)
            {
                Console.WriteLine($"{data.Key} : {data.Value}");
            }
        }
    }
}
