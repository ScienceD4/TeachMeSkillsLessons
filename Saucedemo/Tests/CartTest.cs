using Saucedemo.PageObjects;
using Saucedemo.PageObjects.Parameters;

namespace Saucedemo.Tests;

[TestFixture]
public class CartTest : BaseTest
{
    [Test]
    public void AddToCartProductsTest()
    {
        var inventoryPage = new LoginPage(Driver)
            .Show()
            .LoginGlitchUser()
            .GetData();

        var inventoryItems = new List<UIInventoryItem>();
        for (int i = 0; i < 3 && i < inventoryPage.UIInventoryItems.Count; i++)
        {
            inventoryPage.UIInventoryItems[i].AddToCart();
            inventoryItems.Add(inventoryPage.UIInventoryItems[i]);
        }

        var cartPage = inventoryPage.OpenCart().GetData();
        var cartItems = cartPage.UICartItems.ToList();

        Assert.Multiple(() =>
        {
            Assert.That(cartItems.Count, Is.EqualTo(inventoryItems.Count));

            for (int i = 0; i < inventoryItems.Count; i++)
            {
                Assert.That(cartItems[i].Name, Is.EqualTo(inventoryItems[i].Name));
                Assert.That(cartItems[i].Description, Is.EqualTo(inventoryItems[i].Description));
                Assert.That(cartItems[i].Price, Is.EqualTo(inventoryItems[i].Price));
                Assert.That(cartItems[i].Quantity, Is.EqualTo(1));
            }
        });
    }

    [Test]
    public void AddAndRemoveProductsTest()
    {
        var inventoryPage = new LoginPage(Driver)
            .Show()
            .LoginGlitchUser()
            .GetData();

        var inventoryItems = new List<UIInventoryItem>();
        for (int i = 0; i < 3 && i < inventoryPage.UIInventoryItems.Count; i++)
        {
            inventoryPage.UIInventoryItems[i].AddToCart();
            inventoryItems.Add(inventoryPage.UIInventoryItems[i]);
        }

        var cartPage = inventoryPage.OpenCart().GetData();

        for (int i = 0; i < inventoryItems.Count - 1; i++)
        {
            cartPage.UICartItems.Last().Remove();
            cartPage.GetData();
        }

        var cartItems = cartPage.UICartItems.ToList();

        Assert.Multiple(() =>
        {
            Assert.That(cartItems.Count, Is.EqualTo(1));

            Assert.That(cartItems[0].Name, Is.EqualTo(inventoryItems[0].Name));
            Assert.That(cartItems[0].Description, Is.EqualTo(inventoryItems[0].Description));
            Assert.That(cartItems[0].Price, Is.EqualTo(inventoryItems[0].Price));
            Assert.That(cartItems[0].Quantity, Is.EqualTo(1));
        });
    }
}