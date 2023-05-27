using HomeWork12.PageObjects;

namespace HomeWork12.Selenium;

[TestFixture]
public class DropDownTest : BaseTest
{
    [Test]
    public void SelectorTest()
    {
        var expectedCount = 3;

        var page = new DropDownPage(Driver).Show();

        int countElements = page.CountElements();

        var isSelectOne = page.SelectElement(1).ElementIsSelected(1);

        var isSelectTwo = page.SelectElement(2).ElementIsSelected(2);

        Assert.Multiple(() =>
        {
            Assert.That(countElements, Is.EqualTo(expectedCount));
            Assert.That(isSelectOne, Is.True);
            Assert.That(isSelectTwo, Is.True);
        });
    }
}