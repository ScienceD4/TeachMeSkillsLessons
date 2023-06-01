using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeWork12.Selenium;

public class BaseTest
{
    protected WebDriver Driver { get; set; }

    [SetUp]
    public virtual void SetUp()
    {
        var options = new ChromeOptions();

        if (true)
        {
            options.AddArgument("--headless");
        }

        Driver = new ChromeDriver(options);
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        Driver.Manage().Window.Maximize();
    }

    [TearDown]
    public virtual void TearDown()
    {
        Driver.Dispose();
    }
}