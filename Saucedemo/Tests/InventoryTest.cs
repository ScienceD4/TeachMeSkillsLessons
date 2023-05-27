using Saucedemo.PageObjects;

namespace Saucedemo.Tests;

[TestFixture]
public class InventoryTest : BaseTest
{
    [Test]
    public void SortSelectTitleTest()
    {
        var inventoryPage = new LoginPage(Driver)
            .Show()
            .LoginStandardUser()
            .SelectSort(ProductSort.az)
            .GetData();

        var inventoryNameBefore = inventoryPage.UIInventoryItems.Select(x => x.Name).ToList();
        bool isSortedBefore = inventoryNameBefore.SequenceEqual(inventoryNameBefore.OrderBy(x => x));

        inventoryPage.SelectSort(ProductSort.za).GetData();

        var inventoryNameAfter = inventoryPage.UIInventoryItems.Select(x => x.Name).ToList();
        bool isSortedAfter = inventoryNameAfter.SequenceEqual(inventoryNameAfter.OrderByDescending(x => x));

        Assert.Multiple(() =>
        {
            Assert.That(isSortedBefore, Is.True);
            Assert.That(isSortedAfter, Is.True);
        });
    }

    [Test]
    public void SortSelectPriceTest()
    {
        var inventoryPage = new LoginPage(Driver)
            .Show()
            .LoginStandardUser()
            .SelectSort(ProductSort.lohi)
            .GetData();

        var inventoryPriceBefore = inventoryPage.UIInventoryItems.Select(x => x.Price).ToList();
        bool isSortedBefore = inventoryPriceBefore.SequenceEqual(inventoryPriceBefore.OrderBy(x => x));

        inventoryPage.SelectSort(ProductSort.hilo).GetData();

        var inventoryPriceAfter = inventoryPage.UIInventoryItems.Select(x => x.Price).ToList();
        bool isSortedAfter = inventoryPriceAfter.SequenceEqual(inventoryPriceAfter.OrderByDescending(x => x));

        Assert.Multiple(() =>
        {
            Assert.That(isSortedBefore, Is.True);
            Assert.That(isSortedAfter, Is.True);
        });
    }
}