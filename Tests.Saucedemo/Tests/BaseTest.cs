using Allure.Net.Commons;
using Core;
using OpenQA.Selenium.Support.Extensions;

namespace Saucedemo.Tests;

public class BaseTest
{
    protected AllureLifecycle allure;

    [SetUp]
    public virtual void SetUp()
    {
        allure = AllureLifecycle.Instance;
    }

    [TearDown]
    public virtual void TearDown()
    {
        var screen = Browser.Instance.Driver.TakeScreenshot();
        var screenBytes = screen.AsByteArray;

        if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
        {
            allure.AddAttachment("ScreenShotFail", "image/png", screenBytes);
        }
        else
        {
            allure.AddAttachment("ScreenShot", "image/png", screenBytes);
        }

        Browser.Instance.CloseBrowser();
    }
}