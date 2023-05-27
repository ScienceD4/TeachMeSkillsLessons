using HomeWork12.UIParameters;
using OpenQA.Selenium;

namespace HomeWork12.PageObjects;

public class DataTablesPage : BasePage
{
    private static readonly By locatorTable1 = By.Id("table1");
    private static readonly By locatorTable2 = By.Id("table2");

    private IWebElement Link => Driver.FindElement(By.LinkText("Sortable Data Tables"));

    public TableParameter TableParameter1 { get; set; }
    public TableParameter TableParameter2 { get; set; }


    public DataTablesPage(WebDriver driver) : base(driver)
    {
        TableParameter1 = new(Driver, locatorTable1);
        TableParameter2 = new(Driver, locatorTable2);
    }

    public DataTablesPage Show()
    {
        Open();
        Link.Click();

        return this;
    }
}
