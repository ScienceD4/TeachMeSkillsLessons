using OpenQA.Selenium;

namespace Saucedemo.PageObjects;

public abstract class BasePage
{
    protected static readonly string url = "https://www.saucedemo.com/";
    protected const int TIME_OUT_LOAD_PAGE = 10_000;

    protected IWebDriver Driver { get; }

    protected BasePage(IWebDriver driver)
    {
        Driver = driver;
    }

    public abstract bool IsExist();
}