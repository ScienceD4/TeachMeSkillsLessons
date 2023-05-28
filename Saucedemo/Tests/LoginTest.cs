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

    [Test]
    public void LogoutStandardUser()
    {
        var page = new LoginPage(Driver)
            .Show()
            .LoginStandardUser()
            .BurgerMenu.Show()
            .Logout();

        Assert.That(page.IsExist(), Is.True);
    }

    [Test]
    public void LoginLockedUser()
    {
        var expextedError = "Sorry, this user has been locked out";

        var page = new LoginPage(Driver)
            .Show()
            .LoginLockedUser();

        var text = page.GetErrorMessage();

        Assert.Multiple(() =>
        {
            Assert.That(page.IsExist(), Is.True);
            Assert.That(text, Does.Contain(expextedError));

        });

    }
}