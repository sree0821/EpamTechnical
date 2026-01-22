using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

[Binding]
public class Hooks
{
    public static IWebDriver Driver;

    [BeforeScenario]
    public void BeforeScenario()
    {
        Driver = new ChromeDriver();
        Driver.Manage().Window.Maximize();
        Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
    }

    [AfterScenario]
    public void AfterScenario()
    {
        Driver.Quit();
    }
}
