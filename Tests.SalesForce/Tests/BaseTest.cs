using Core;

namespace SalesForce.Tests;

public class BaseTest
{
    [TearDown]
    public void TearDown()
    {
        Browser.Instance.CloseBrowser();
    }
}