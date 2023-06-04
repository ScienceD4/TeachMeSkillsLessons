using Core;

namespace SalesForce.Elements;

public abstract class BaseElement
{
    private readonly By locator;
    protected IWebDriver Driver => Browser.Instance.Driver;
    public IWebElement WebElement => Driver.FindElement(locator);

    protected BaseElement(By locator)
    {
        this.locator = locator;
    }
}