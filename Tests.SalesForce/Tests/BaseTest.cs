using Allure.Net.Commons;
using Core;
using NUnit.Allure.Core;
using OpenQA.Selenium.Support.Extensions;

namespace Tests.SalesForce.Tests;

[AllureNUnit]
public class BaseTest
{
    private AllureLifecycle allure;

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        allure = AllureLifecycle.Instance;
    }

    [TearDown]
    public void TearDown()
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