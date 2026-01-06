using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task1
{
    internal class StringOperations
    {
        public void Concatenation()
        {
            string firstName = "Sree";
            string lastName = "Lakshmi";

            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Concatenation Result: {fullName}");
        }

        public void Navigation()
        {
            string text = "Automation";

            Console.WriteLine($"First character: {text[0]}");
            Console.WriteLine($"Last character: {text[text.Length - 1]}");

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i] + " ");
            }
            Console.WriteLine();
        }

        public void Comparison()
        {
            string value1 = "epam";
            string value2 = "EPAM";

            bool isEqual = value1.Equals(value2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine($"Strings equal (ignore case): {isEqual}");
        }
    }
}
