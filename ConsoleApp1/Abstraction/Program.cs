
using ConsoleApp1.Abstraction;
using IncubationProject.Tests;

internal class Program
{
    static void Main(string[] args)
    {
        BrowserDriver driver = new ChromeBrowserDriver();
        TestExecution test = new TestExecution(driver);

        test.RunTest();

        Console.ReadLine();
    }
}