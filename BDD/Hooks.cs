using Allure.Commons;
using Core;
using NUnit.Allure.Core;

namespace BDD;

[Binding]
public class Hooks
{
    [AfterTestRun]
    public static void AfterTests()
    {
        Browser.Instance.CloseBrowser();
    }
}