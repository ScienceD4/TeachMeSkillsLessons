using Common;
using Saucedemo.PageObjects.Parameters;

namespace Saucedemo.PageObjects;

public class CartPage : BasePage
{
    private readonly By checkOutButton = By.CssSelector("[data-test='checkout']");
    private readonly By cartItems = By.CssSelector(".cart_item");

    private IWebElement CheckOutButton => Driver.FindElement(checkOutButton);
    private IReadOnlyCollection<IWebElement> CartItems => Driver.FindElements(cartItems);

    public List<UICartItem>? UICartItems { get; set; }

    public CartPage() : base()
    {
        Driver.WaitLoad(x => IsExist(), TIME_OUT_LOAD_PAGE);
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

    public CheckoutPage Checkout()
    {
        CheckOutButton.Click();

        return new CheckoutPage();
    }

    public override bool IsExist()
    {
        return CheckOutButton.Displayed;
    }
}