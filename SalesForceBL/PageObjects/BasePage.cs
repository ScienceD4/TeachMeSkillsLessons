using Common;
using OpenQA.Selenium.Support.UI;

namespace SalesForceBL.PageObjects;

public abstract class BasePage
{
    protected static IWebDriver Driver => Core.Browser.Instance.Driver;

    protected static TResult Wait<TResult>(Func<IWebDriver, TResult> condition, int timeout)
    {
        return Driver.WaitLoad(condition, timeout);
    }
}