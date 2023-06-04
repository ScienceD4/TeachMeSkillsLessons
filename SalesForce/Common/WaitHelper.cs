using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SalesForce.PageObjects;

namespace Common;

public static class WaitHelper
{
    public static void Until(int time, Func<bool> predicate)
    {
        var timeout = DateTime.Now.AddMilliseconds(time);

        while (DateTime.Now < timeout)
        {
            if (predicate.Invoke())
                return;
        }
    }

    public static void WaitLoadPage(this IWebDriver driver, Predicate<IWebDriver> predicate, int timeout)
    {
        new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeout)).Until(d => predicate?.Invoke(d));
    }
}