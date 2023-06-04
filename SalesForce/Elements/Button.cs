namespace SalesForce.Elements;

public class Button : BaseElement
{
    public Button(By locator) : base(locator)
    {
    }

    public void Click()
    {
        WebElement.Click();
    }
}