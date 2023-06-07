namespace SalesForce.Elements;

public class Span : BaseElement
{
    public string Text => WebElement.Text;
    public Span(By locator) : base(locator)
    {
    }
}
