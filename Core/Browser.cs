using Allure.Net.Commons;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;

namespace Core;

public class Browser
{
    private static readonly ThreadLocal<Browser> browserInstances = new();
    private readonly IWebDriver driver;

    public IWebDriver Driver => driver;

    public static Browser Instance => browserInstances.Value ??= new Browser();

    protected AllureLifecycle allure = AllureLifecycle.Instance;

    private Browser()
    {
        driver = GetDriver();
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
        browserInstances.Value = null;
    }

    private static IWebDriver GetDriver()
    {
        var browser = Settings.Settings.Browser.Type;

        IWebDriver webDriver;

        switch (browser)
        {
            case "chrome":
                var options = new ChromeOptions();

                if (Settings.Settings.Browser.HeadLess)
                {
                    options.AddArgument("--headless");
                }

                options.AddArgument("--no-sandbox");
                options.AddArgument("--disable-extensions");

                webDriver = new ChromeDriver(options);
                break;

            default:
                webDriver = new ChromeDriver();
                break;
        }

        webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Settings.Settings.Browser.TimeOutSeconds);
        webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Settings.Settings.Browser.TimeOutSeconds * 3);
        webDriver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);

        return webDriver;
    }

    public void ContextClickElement(IWebElement element)
    {
        new Actions(Driver)
            .ContextClick(element)
            .Perform();
    }

    public void TakeScreenShot(string title = "screenShot")
    {
        var screen = Driver.TakeScreenshot();
        var screenBytes = screen.AsByteArray;
        allure.AddAttachment(title, "image/png", screenBytes);
    }
}