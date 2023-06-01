using HomeWork12.PageObjects;

namespace HomeWork12.Selenium;

[TestFixture]
public class ContextMenuTest : BaseTest
{
    [Test]
    public void CheckTextFromAlert()
    {
        var expectedText = "You selected a context menu";

        var page = new ContextMenuPage(Driver).Show();

        var text = page.RightClickContextBoxAndGetText();

        Assert.That(text, Is.EqualTo(expectedText));
    }
}
