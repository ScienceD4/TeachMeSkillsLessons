using OpenQA.Selenium;

namespace SalesForce.PageObjects;

public abstract class BasePage
{
    protected static IWebDriver Driver => Core.Browser.Instance.Driver;
}