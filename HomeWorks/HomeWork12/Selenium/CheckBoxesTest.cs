using HomeWork12.PageObjects;

namespace HomeWork12.Selenium;

[TestFixture]
public class CheckBoxesTest : BaseTest
{
    [Test]
    public void SelectCheckBoxesTest()
    {
        var page = new CheckBoxesPage(Driver).Show();

        Assert.Multiple(() =>
        {
            Assert.That(page.CheckBoxIsChecked(0), Is.False);
            Assert.That(page.CheckBoxIsChecked(1), Is.True);
        });

        page.SetCheckBoxState(0, true)
            .SetCheckBoxState(1, false);

        Assert.Multiple(() =>
        {
            Assert.That(page.CheckBoxIsChecked(0), Is.True);
            Assert.That(page.CheckBoxIsChecked(1), Is.False);
        });
    }
}