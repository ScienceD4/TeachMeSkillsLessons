namespace Saucedemo.PageObjects.Parameters;

public class UIDetailsItem : UIProductItem
{
    private readonly By addButton = By.CssSelector(".btn.btn_primary.btn_small.btn_inventory");
    private readonly By removeButton = By.CssSelector(".btn.btn_secondary.btn_small");

    public UIDetailsItem(ISearchContext searchContext) : base(searchContext)
    {
        nameDiv = By.CssSelector(".inventory_details_name");
        descriptionDiv = By.CssSelector(".inventory_details_desc");
        priceDiv = By.CssSelector(".inventory_details_price");
    }

    public void AddToCart()
    {
        searchContext.FindElement(addButton).Click();
    }

    public void Remove()
    {
        searchContext.FindElement(removeButton).Click();
    }

    public override UIDetailsItem GetData()
    {
        base.GetData();

        return this;
    }
}