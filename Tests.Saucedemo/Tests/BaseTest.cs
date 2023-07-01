using Allure.Net.Commons;
using Core;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Saucedemo.Tests;

[AllureNUnit]
[Parallelizable(ParallelScope.All)]
public class BaseTest
{
    [TearDown]
    public virtual void TearDown()
    {
        if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
        {
            Browser.Instance.TakeScreenShot("ScreenShotFail");
        }
        else
        {
            Browser.Instance.TakeScreenShot("EndScreenShot");
        }

        Browser.Instance.CloseBrowser();
    }
}