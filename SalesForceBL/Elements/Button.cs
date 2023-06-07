using Core;
using OpenQA.Selenium;

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
    public void ClickByJava()
    {
        Browser.Instance.ExecuteScript("arguments[0].click()", WebElement);
    }
}