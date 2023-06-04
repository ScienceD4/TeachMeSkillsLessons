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
            options.AddUserProfilePreference("download.default_directory", Environment.CurrentDirectory + "\\download\\");

            // Предназначение не известно!
            options.AddUserProfilePreference("download.prompt_for_download", false);
            options.AddUserProfilePreference("disable-popup-blocking", "true");

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