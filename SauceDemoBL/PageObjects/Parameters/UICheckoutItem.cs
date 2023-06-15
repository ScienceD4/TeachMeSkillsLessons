using OpenQA.Selenium;

namespace Saucedemo.PageObjects.Parameters;

public class UICheckoutItem : UIProductItem
{
    private readonly By quantityDiv = By.CssSelector(".cart_quantity");

    public int Quantity { get; set; }

    public UICheckoutItem(ISearchContext searchContext) : base(searchContext)
    {
    }

    public override UICheckoutItem GetData()
    {
        base.GetData();

        if (int.TryParse(searchContext.FindElement(quantityDiv).Text, out int quantity))
        {
            Quantity = quantity;
        }

        return this;
    }
}