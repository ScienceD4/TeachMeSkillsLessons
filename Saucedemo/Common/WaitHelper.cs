using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Saucedemo.PageObjects;

namespace Saucedemo.Common;

public static class WaitHelperExtension
{
    public static void WaitLoadPage(this IWebDriver driver, BasePage page, int timeout)
    {
        new WebDriverWait(driver, TimeSpan.FromMilliseconds(timeout)).Until(x => page.IsExist());
    }
}