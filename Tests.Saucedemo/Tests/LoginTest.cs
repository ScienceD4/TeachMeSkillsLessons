namespace Saucedemo.Tests;

[TestFixture]
public class LoginTest : BaseTest
{
    [Test]
    public void LoginStandardUser()
    {
        var page = new LoginPage()
            .Show()
            .LoginStandardUser();

        Assert.That(page.IsExist(), Is.True);
    }

    [Test]
    public void LoginGlitchUser()
    {
        var page = new LoginPage()
            .Show()
            .LoginGlitchUser();

        Assert.That(page.IsExist(), Is.True);
    }

    [Test]
    public void LogoutStandardUser()
    {
        var page = new LoginPage()
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

        var page = new LoginPage()
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