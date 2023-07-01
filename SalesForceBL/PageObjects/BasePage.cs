using Core.Common;

namespace SalesForceBL.PageObjects;

public abstract class BasePage
{
    protected static IWebDriver Driver => Core.Browser.Instance.Driver;

    protected static TResult Wait<TResult>(Func<IWebDriver, TResult> condition, int timeout)
    {
        return Driver.WaitLoad(condition, timeout);
    }
}