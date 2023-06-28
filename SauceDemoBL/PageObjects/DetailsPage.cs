using Common;
using Core;
using NUnit.Allure.Attributes;
using Saucedemo.PageObjects.Parameters;

namespace Saucedemo.PageObjects;

public class DetailsPage : BasePage
{
    private readonly By shoppingCart = By.CssSelector(".shopping_cart_link");
    private readonly By backButton = By.CssSelector("[data-test='back-to-products']");

    private IWebElement ShoppingCart => Driver.FindElement(shoppingCart);
    private IWebElement BackButton => Driver.FindElement(backButton);

    public UIDetailsItem UIDetailsItem { get; set; }
    public BurgerMenuForm BurgerMenu { get; set; }

    public DetailsPage() : base()
    {
        Driver.WaitLoad(x => IsExist(), TIME_OUT_LOAD_PAGE);
        Browser.Instance.TakeScreenShot("Open DetailsPage");

        BurgerMenu = new BurgerMenuForm();
        UIDetailsItem = new UIDetailsItem(Driver).GetData();
    }

    [AllureStep]
    public InventoryPage BackToProducts()
    {
        BackButton.Click();

        return new InventoryPage();
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
}