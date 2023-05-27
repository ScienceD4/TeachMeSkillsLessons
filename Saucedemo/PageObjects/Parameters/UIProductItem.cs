using OpenQA.Selenium;

namespace Saucedemo.PageObjects.Parameters;

public abstract class UIProductItem
{
    private readonly By nameDiv = By.CssSelector(".inventory_item_name");
    private readonly By descriptionDiv = By.CssSelector(".inventory_item_desc");
    private readonly By priceDiv = By.CssSelector(".inventory_item_price");

    protected ISearchContext searchContext;

    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    protected UIProductItem(ISearchContext searchContext)
    {
        this.searchContext = searchContext;
    }

    public virtual UIProductItem GetData()
    {
        Name = searchContext.FindElement(nameDiv).Text;
        Description = searchContext.FindElement(descriptionDiv).Text;
        Price = double.Parse(searchContext.FindElement(priceDiv).Text.Substring(1).Replace(".", ","));

        return this;
    }
}