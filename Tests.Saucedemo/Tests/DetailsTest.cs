using Saucedemo.PageObjects.Parameters;

namespace Saucedemo.Tests;

[TestFixture]
public class DetailsTest : BaseTest
{
    [Test]
    public void CheckProductDetails()
    {
        var inventoryPage = new LoginPage()
            .Show()
            .LoginStandardUser()
        .GetData();

        var indexItem = new Random().Next(inventoryPage.UIInventoryItems?.Count ??
            throw new Exception($"'{nameof(inventoryPage.UIInventoryItems)}' is null"));

        var inventoryItem = inventoryPage.UIInventoryItems[indexItem];
        var detailsPage = inventoryItem.Details().UIDetailsItem;

        Assert.Multiple(() =>
        {
            Assert.That(detailsPage.Name, Is.EqualTo(inventoryItem.Name));
            Assert.That(detailsPage.Description, Is.EqualTo(inventoryItem.Description));
            Assert.That(detailsPage.Price, Is.EqualTo(inventoryItem.Price));
        });
    }
}