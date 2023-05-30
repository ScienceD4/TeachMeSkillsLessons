using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Saucedemo.Core;

public class Browser
{
    private static Browser instance;
    private IWebDriver driver;
    private bool isHeadLess = true;

    public IWebDriver Driver { get { return driver; } }

    public static Browser Instance
    {
        get
        {
            return instance ??= new Browser();
        }
    }

    private Browser()
    {
        var options = new ChromeOptions();

        if (isHeadLess)
        {
            options.AddArgument("--headless");
        }

        driver = new ChromeDriver(options);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
        driver.Manage().Window.Maximize();
    }

    public void NavigateToUrl(string url)
    {
        Driver.Navigate().GoToUrl(url);
    }
    public void CloseBrowser()
    {
        Driver?.Dispose();
        instance = null;
    }
}