using OpenQA.Selenium;
using Saucedemo.PageObjects.Parameters;

namespace Saucedemo.PageObjects;

public class CartPage : BasePage
{
    private readonly By checkOutButton = By.CssSelector("[data-test='checkout']");
    private readonly By cartItems = By.CssSelector(".cart_item");

    private IWebElement CheckOutButton => Driver.FindElement(checkOutButton);
    private IReadOnlyCollection<IWebElement> CartItems => Driver.FindElements(cartItems);

    public List<UICartItem> UICartItems { get; set; }

    public CartPage(IWebDriver driver) : base(driver)
    {
    }

    public CartPage GetData()
    {
        UICartItems = new List<UICartItem>();

        if (CartItems.Any())
        {
            foreach (var item in CartItems)
            {
                UICartItems.Add(new UICartItem(item).GetData());
            }
        }

        return this;
    }

    public CheckuotPage Checkout()
    {
        CheckOutButton.Click();

        return new CheckuotPage(Driver);
    }
}