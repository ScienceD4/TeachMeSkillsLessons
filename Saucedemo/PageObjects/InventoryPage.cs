using OpenQA.Selenium;

namespace Saucedemo.PageObjects;

public class InventoryPage : BasePage
{
    readonly By shoppingCart = By.CssSelector(".shopping_cart_link");

    IWebElement ShoppingCart => Driver.FindElement(shoppingCart);

    public InventoryPage(IWebDriver driver) : base(driver)
    {
    }

    public bool IsExist()
    {
        return ShoppingCart.Displayed;
    }
}
