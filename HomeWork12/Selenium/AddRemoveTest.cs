using HomeWork12.PageObjects;

namespace HomeWork12.Selenium;

[TestFixture]
public class AddRemoveTest : BaseTest
{
    [Test]
    public void AddRemoveElementsTest()
    {
        var expected = 2;

        var countElements = new AddRemovePage(Driver)
            .Show()
            .AddElement()
            .AddElement()
            .DelElement()
            .CountElements();

        Assert.That(countElements, Is.EqualTo(expected));
    }
}