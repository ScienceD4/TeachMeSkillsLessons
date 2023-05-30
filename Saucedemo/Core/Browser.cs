using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;

namespace Saucedemo.Core;

public class Browser
{
    private static Browser? instance;
    private readonly IWebDriver driver;
    private readonly bool isHeadLess = true;

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
        isHeadLess = bool.Parse(TestContext.Parameters.Get("HeadLess") ?? "false");

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

    public void SwitchToFrame(IWebElement frame)
    {
        Driver.SwitchTo().Frame(frame);
    }

    public void SwitchToDefaultContent()
    {
        Driver.SwitchTo().DefaultContent();
    }

    public void ExecuteScript(string script, params object[] arg)
    {
        Driver.ExecuteJavaScript(script, arg);
    }

    public void CloseBrowser()
    {
        Driver?.Dispose();
        instance = null;
    }
}