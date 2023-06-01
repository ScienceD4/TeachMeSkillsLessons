using HomeWork12.PageObjects;

namespace HomeWork12.Selenium;

[TestFixture]
public class DynamicControlsTest : BaseTest
{
    [Test]
    public void Test()
    {
        var page = new DynamicControlsPage(Driver).Show().SetCheckBoxState(true);

        var c = page.CheckBoxIsChecked();
    }
}
