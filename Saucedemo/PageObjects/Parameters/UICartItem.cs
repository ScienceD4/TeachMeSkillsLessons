using OpenQA.Selenium;
using System.Diagnostics;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Saucedemo.PageObjects.Parameters;

public class UICartItem : UIProductItem
{
    readonly By quantityDiv = By.CssSelector(".cart_quantity");
    readonly By removeButton = By.CssSelector(".btn.btn_secondary.btn_small");

    public int Quantity { get; set; }

    public UICartItem(ISearchContext searchContext) : base(searchContext)
    {
    }

    public void Remove()
    {
        searchContext.FindElement(removeButton).Click();
    }

    public override UICartItem GetData()
    {
        base.GetData();

        if (int.TryParse(searchContext.FindElement(quantityDiv).Text, out int quantity))
        {
            Quantity = quantity;
        }

        return this;
    }
}
