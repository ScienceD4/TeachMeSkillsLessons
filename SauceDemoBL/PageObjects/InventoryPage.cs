using Common;
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

    public List<UIInventoryItem> UIInventoryItems { get; set; }
    public BurgerMenuForm BurgerMenu { get; set; }

    public InventoryPage(IWebDriver driver) : base(driver)
    {
        Driver.WaitLoad(x => IsExist(), TIME_OUT_LOAD_PAGE);
        BurgerMenu = new BurgerMenuForm(driver);
    }

    public CartPage OpenCart()
    {
        ShoppingCart.Click();

        return new CartPage(Driver);
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
                UIInventoryItems.Add(new UIInventoryItem(Driver, item).GetData());
            }
        }

        return this;
    }

    public InventoryPage SelectSort(ProductSort sortType)
    {
        var select = new SelectElement(SortSelect);

        select.SelectByValue(sortType.ToString());

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