using Saucedemo.PageObjects;

namespace Saucedemo.Tests;

[TestFixture]
public class LoginTest : BaseTest
{
    [Test]
    public void LoginStandardUser()
    {
        var page = new LoginPage(Driver)
            .Show()
            .LoginStandardUser();

        Assert.That(page.IsExist(), Is.True);
    }
}
