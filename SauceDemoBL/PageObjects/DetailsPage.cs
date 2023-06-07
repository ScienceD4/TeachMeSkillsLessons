using Common;
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

    public DetailsPage(IWebDriver driver) : base(driver)
    {
        Driver.WaitLoad(x => IsExist(), TIME_OUT_LOAD_PAGE);
        BurgerMenu = new BurgerMenuForm(driver);
        UIDetailsItem = new UIDetailsItem(driver).GetData();
    }

    public InventoryPage BackToProducts()
    {
        BackButton.Click();

        return new InventoryPage(Driver);
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
}