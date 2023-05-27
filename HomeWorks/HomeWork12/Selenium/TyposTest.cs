using HomeWork12.PageObjects;

namespace HomeWork12.Selenium;

[TestFixture]
public class TyposTest : BaseTest
{
    [Test]
    [Retry(3)]
    public void OneTimeCheckTest()
    {
        var expextedError = "won,t";

        var page = new TyposPage(Driver).Show();

        var paragraphs = page.GetParagraphs();

        Assert.That(paragraphs, Is.Not.Contains(expextedError));
    }

    [Test]
    public void RefreshTest()
    {
        var expextedError = "won,t";
        var paragraphs = new List<string> { expextedError };

        var page = new TyposPage(Driver).Show();

        var timeout = DateTime.Now.AddMinutes(1);
        while (DateTime.Now < timeout)
        {
            paragraphs = page.GetParagraphs();
            if (!paragraphs.Contains(expextedError)) break;
            page.Refresh();
        }

        Assert.That(paragraphs, Is.Not.Contains(expextedError));
    }
}
