using HomeWork12.PageObjects;

namespace HomeWork12.Selenium;

[TestFixture]
public class DataTablesTest : BaseTest
{
    [Test]
    public void TableRowsTest()
    {
        var expectedItem1 = "Smith";
        var expectedItem2 = "Frank";
        var expectedItem3 = "jdoe@hotmail.com";
        var expectedItem4 = "$51.00";
        var expectedItem5 = "http://www.jdoe.com";

        var page = new DataTablesPage(Driver).Show();
        var table = page.TableParameter1.GetData();

        var actualItem1 = table.Rows[0][table.Columns[0]];
        var actualItem2 = table.Rows[1][table.Columns[1]];
        var actualItem3 = table.Rows[2][table.Columns[2]];
        var actualItem4 = table.Rows[1][table.Columns[3]];
        var actualItem5 = table.Rows[2][table.Columns[4]];

        Assert.Multiple(() =>
        {
            Assert.That(actualItem1, Is.EqualTo(expectedItem1));
            Assert.That(actualItem2, Is.EqualTo(expectedItem2));
            Assert.That(actualItem3, Is.EqualTo(expectedItem3));
            Assert.That(actualItem4, Is.EqualTo(expectedItem4));
            Assert.That(actualItem5, Is.EqualTo(expectedItem5));
        });
    }
}
