using Saucedemo.PageObjects;

namespace Saucedemo.Tests;

[TestFixture]
public class CheckoutTest : BaseTest
{
    [Test]
    public void BuyProductsTest()
    {
        var inventoryPage = new LoginPage(Driver)
            .Show()
            .LoginStandardUser()
            .GetData();

        for (int i = 0; i < 3 && i < inventoryPage.UIInventoryItems.Count; i++)
        {
            inventoryPage.UIInventoryItems[i].AddToCart();
        }

        var cartPage = inventoryPage.OpenCart().GetData();
        var cartItems = cartPage.UICartItems.ToList();

        var checkoutPage = cartPage.Checkout().Continue().GetData();
        var checkItems = checkoutPage.UICheckoutItems.ToList();

        inventoryPage = checkoutPage.Finish().BackHome();

        Assert.Multiple(() =>
        {
            Assert.That(inventoryPage.IsExist(), Is.True);

            for (int i = 0; i < cartItems.Count; i++)
            {
                Assert.That(cartItems[i].Name, Is.EqualTo(checkItems[i].Name));
                Assert.That(cartItems[i].Description, Is.EqualTo(checkItems[i].Description));
                Assert.That(cartItems[i].Price, Is.EqualTo(checkItems[i].Price));

                Assert.That(cartItems[i].Quantity, Is.EqualTo(1));
                Assert.That(checkItems[i].Quantity, Is.EqualTo(1));
            }
        });
    }
}