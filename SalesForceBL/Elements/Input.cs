using OpenQA.Selenium;

namespace SalesForce.Elements;

public class Input : BaseElement
{
    public Input(By locator) : base(locator)
    {
    }

    public void FillIn(string text)
    {
        if (string.IsNullOrEmpty(text)) return;

        WebElement.SendKeys(text);
    }
}