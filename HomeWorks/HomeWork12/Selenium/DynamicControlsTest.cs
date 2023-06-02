using HomeWork12.PageObjects;

namespace HomeWork12.Selenium;

[TestFixture]
public class DynamicControlsTest : BaseTest
{
    [Test]
    public void ControlsTest()
    {
        var expectedCheckBoxMessage = "It's gone!";
        var expectedInputMessage = "It's enabled!";

        var page = new DynamicControlsPage(Driver).Show().SetCheckBoxState(true);

        var checkBoxIsExist = page.CheckBoxIsExist();

        page.RemoveCheckBox();
        Until(30_000, () => !page.CheckBoxIsExist());

        var checkBoxMessage = page.GetCheckBoxMessage();
        var checkBoxIsExist2 = page.CheckBoxIsExist();

        var inputIsEnable = page.InputIsEnable();

        page.EnableInput();
        Until(30_000, () => page.InputIsEnable());

        var inputMessage = page.GetInputMessage();
        var inputIsEnable2 = page.InputIsEnable();

        Assert.Multiple(() =>
        {
            Assert.That(checkBoxIsExist, Is.True);
            Assert.That(checkBoxIsExist2, Is.False);
            Assert.That(inputIsEnable, Is.False);
            Assert.That(inputIsEnable2, Is.True);
            Assert.That(checkBoxMessage, Is.EqualTo(expectedCheckBoxMessage));
            Assert.That(inputMessage, Is.EqualTo(expectedInputMessage));
        });


    }

    private static void Until(int time, Func<bool> predicate)
    {
        var timeout = DateTime.Now.AddMilliseconds(time);

        while (DateTime.Now < timeout)
        {
            if (predicate.Invoke())
                return;
        }
    }
}