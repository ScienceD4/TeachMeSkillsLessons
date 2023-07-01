using Core.Common;
using Core;
using NUnit.Allure.Attributes;
using OpenQA.Selenium.Support.UI;
using Saucedemo.PageObjects.Parameters;

namespace Saucedemo.PageObjects;

public class InventoryPage : BasePage
{
    private readonly By shoppingCart = By.CssSelector(".shopping_cart_link");
    private readonly By inventoryItems = By.CssSelector(".inventory_item");
    private readonly By inventorySort = By.CssSelector("[data-test='product_sort_container']");

    private IWebElement ShoppingCart => Driver.FindElement(shoppingCart);
    private IWebElement SortSelect => Driver.FindElement(inventorySort);
    private IReadOnlyCollection<IWebElement> InventoryItems => Driver.FindElements(inventoryItems);

    public List<UIInventoryItem>? UIInventoryItems { get; set; }
    public BurgerMenuForm BurgerMenu { get; set; }

    public InventoryPage() : base()
    {
        Driver.WaitLoad(x => IsExist(), TIME_OUT_LOAD_PAGE);
        Browser.Instance.TakeScreenShot("Open InventoryPage");

        BurgerMenu = new BurgerMenuForm();
    }

    [AllureStep]
    public CartPage OpenCart()
    {
        ShoppingCart.Click();

        return new CartPage();
    }

    public override bool IsExist()
    {
        return ShoppingCart.Displayed;
    }

    public InventoryPage GetData()
    {
        UIInventoryItems = new List<UIInventoryItem>();

        if (InventoryItems.Any())
        {
            foreach (var item in InventoryItems)
            {
                UIInventoryItems.Add(new UIInventoryItem(item).GetData());
            }
        }

        return this;
    }

    [AllureStep]
    public InventoryPage SelectSort(ProductSort sortType)
    {
        var select = new SelectElement(SortSelect);

        select.SelectByValue(sortType.ToString());
        Browser.Instance.TakeScreenShot("SelectSort");

        return this;
    }
}

public enum ProductSort
{
    az,
    za,
    lohi,
    hilo,
}