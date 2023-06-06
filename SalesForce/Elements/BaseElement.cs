using Common;
using Core;

namespace SalesForce.Elements;

public abstract class BaseElement
{
    private readonly By locator;
    protected IWebDriver Driver => Browser.Instance.Driver;

    public IWebElement WebElement => Driver.WaitLoad(d => d.FindElement(locator), 5_000);
    public bool IsExist => ElementIsExist();

    protected BaseElement(By locator)
    {
        this.locator = locator;
    }

    private bool ElementIsExist()
    {
        try
        {
            return WebElement.Displayed;
        }
        catch
        {
            return false;
        }
    }
}