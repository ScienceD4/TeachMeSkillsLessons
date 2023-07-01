using Core;

namespace Saucedemo.PageObjects;

public abstract class BasePage
{
    protected static readonly string url = "https://www.saucedemo.com/";
    protected const int TIME_OUT_LOAD_PAGE = 10_000;

    protected IWebDriver Driver { get; }

    protected BasePage()
    {
        Driver = Browser.Instance.Driver;
    }

    public abstract bool IsExist();
}