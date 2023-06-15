namespace SalesForceBL.Elements;

public class Span : BaseElement
{
    public string Text => WebElement.Text;
    public Span(By locator) : base(locator)
    {
    }
}
