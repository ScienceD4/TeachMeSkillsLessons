using OpenQA.Selenium;

namespace Core.WebElements;

public class Span : BaseElement
{
    public string Text => WebElement.Text;

    public Span(By locator) : base(locator)
    {
    }
}