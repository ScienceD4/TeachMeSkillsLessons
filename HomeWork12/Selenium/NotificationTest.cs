using HomeWork12.PageObjects;

namespace HomeWork12.Selenium;

[TestFixture]
public class NotificationTest : BaseTest
{
    [Test]
    public void NotificationMessageTest()
    {
        var expectedText = "Action successful";

        var page = new NotificationPage(Driver).Show();
        var text = string.Empty;

        var timeout = DateTime.Now.AddMinutes(3);
        while(DateTime.Now < timeout)
        {
            text = page.Click().GetTextNotification();
            if (text.Equals(expectedText)) break;
        }


        Assert.That(text, Is.EqualTo(expectedText));
    }
}
