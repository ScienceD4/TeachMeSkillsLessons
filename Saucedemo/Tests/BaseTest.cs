using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Saucedemo.Tests;

public class BaseTest
{
    protected WebDriver Driver { get; set; }

    [SetUp]
    public virtual void SetUp()
    {
        Driver = new ChromeDriver();
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
        Driver.Manage().Window.Maximize();
    }

    [TearDown]
    public virtual void TearDown()
    {
        //Thread.Sleep(2000);
        Driver.Dispose();
    }
}