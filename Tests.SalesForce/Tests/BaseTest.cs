using Core;

namespace Tests.SalesForce.Tests;

public class BaseTest
{
    [TearDown]
    public void TearDown()
    {
        Browser.Instance.CloseBrowser();
    }
}