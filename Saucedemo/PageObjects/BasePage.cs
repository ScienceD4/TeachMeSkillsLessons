using OpenQA.Selenium;

namespace Saucedemo.PageObjects;

public  abstract class BasePage
{
    protected readonly static string url = "https://www.saucedemo.com/";

    protected IWebDriver Driver { get; }

    protected BasePage(IWebDriver driver)
    {
        Driver = driver;
    }
}
