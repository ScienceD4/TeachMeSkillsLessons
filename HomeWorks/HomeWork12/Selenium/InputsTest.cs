using HomeWork12.PageObjects;
using OpenQA.Selenium;

namespace HomeWork12.Selenium;

[TestFixture]
public class InputsTest : BaseTest
{
    [Test]
    public void NumbersAndTextTest()
    {
        var expectedNums = "123456";
        var expectedNums2 = "123458";
        var expectedNums3 = "123454";
        var expectedText = "qwerty";

        var page = new InputsPage(Driver).Show();

        var actualNums = page.Clear().SendKeys(expectedNums).GetText();
        var actualNums2 = page.Clear().SendKeys(expectedNums + Keys.ArrowUp + Keys.ArrowUp).GetText();
        var actualNums3 = page.Clear().SendKeys(expectedNums + Keys.ArrowDown + Keys.ArrowDown).GetText();
        var actualText = page.Clear().SendKeys(expectedText).GetText();

        Assert.Multiple(() =>
        {
            Assert.That(actualNums, Is.EqualTo(expectedNums));
            Assert.That(actualNums2, Is.EqualTo(expectedNums2));
            Assert.That(actualNums3, Is.EqualTo(expectedNums3));
            Assert.That(actualText, Is.Not.EqualTo(expectedText));
        });
    }
}
