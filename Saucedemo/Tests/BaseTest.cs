using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Saucedemo.Core;

namespace Saucedemo.Tests;

public class BaseTest
{
    protected IWebDriver Driver { get; set; }

    [SetUp]
    public virtual void SetUp()
    {
        Driver = Browser.Instance.Driver;
    }

    [TearDown]
    public virtual void TearDown()
    {
        Browser.Instance.CloseBrowser();
    }
}