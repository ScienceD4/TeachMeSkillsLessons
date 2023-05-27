using HomeWork12.PageObjects;

namespace HomeWork12.Selenium;

[TestFixture]
public class HoversTest : BaseTest
{
    [Test]
    public void CheckProfileTest()
    {
        var expectedText = "Not Found";
        var expectedName0 = "user1";
        var expectedName1 = "user2";
        var expectedName2 = "user3";

        var page = new HoversPage(Driver).Show();

        var name0 = page.GetProfileName(0);
        var text0 = page.ViewProfileAndGetText(0);
        page.Back();

        var name1 = page.GetProfileName(1);
        var text1 = page.ViewProfileAndGetText(1);
        page.Back();

        var name2 = page.GetProfileName(2);
        var text2 = page.ViewProfileAndGetText(2);
        page.Back();

        Assert.Multiple(() =>
        {
            Assert.That(name0, Is.EqualTo(expectedName0));
            Assert.That(name1, Is.EqualTo(expectedName1));
            Assert.That(name2, Is.EqualTo(expectedName2));

            Assert.That(text0, Is.EqualTo(expectedText));
            Assert.That(text1, Is.EqualTo(expectedText));
            Assert.That(text2, Is.EqualTo(expectedText));
        });
    }
}
