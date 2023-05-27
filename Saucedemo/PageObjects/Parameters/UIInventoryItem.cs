using OpenQA.Selenium;

namespace Saucedemo.PageObjects.Parameters;

public class UIInventoryItem : UIProductItem
{
    readonly By addButton = By.CssSelector(".btn.btn_primary.btn_small.btn_inventory");
    readonly By removeButton = By.CssSelector(".btn.btn_secondary.btn_small");

    public UIInventoryItem(ISearchContext searchContext) : base(searchContext)
    {
    }

    public  void AddToCart()
    {
        searchContext.FindElement(addButton).Click();
    }
    public void Remove()
    {
        searchContext.FindElement(removeButton).Click();
    }

    public override UIInventoryItem GetData()
    {
        base.GetData();

        return this;
    }
}