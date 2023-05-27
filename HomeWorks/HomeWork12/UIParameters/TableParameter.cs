using OpenQA.Selenium;
using System.Xml.Linq;

namespace HomeWork12.UIParameters;

public class TableParameter
{
    private static readonly By locatorCol = By.XPath(".//thead//th");
    private static readonly By locatorRows = By.XPath(".//tbody//tr");
    private static readonly By locatorItem = By.XPath(".//td");

    private readonly By locatorWebElement;
    private readonly IWebDriver driver;

    public List<string> Columns { get; set; }
    public List<Dictionary<string, string>> Rows { get; set; }

    public TableParameter(IWebDriver driver, By locatorWebElement)
    {
        this.driver = driver;
        this.locatorWebElement = locatorWebElement;
    }

    public TableParameter GetData()
    {
        Parse();

        return this;
    }

    private void Parse()
    {
        var webElement = driver.FindElement(locatorWebElement);

        Columns = webElement.FindElements(locatorCol).Select(e => e.Text).ToList();
        Rows = new List<Dictionary<string, string>>();

        var webRows = webElement.FindElements(locatorRows);

        foreach (var webRow in webRows)
        {
            var dict = new Dictionary<string, string>();

            var items = webRow.FindElements(locatorItem).Select(e => e.Text).ToList();

            var itemslen = items.Count;
            for (int i = 0; i < Columns.Count; i++)
            {
                if (i < itemslen)
                {
                    dict.Add(Columns[i], items[i]);
                }
                else
                {
                    dict.Add(Columns[i], string.Empty);
                }
            }

            Rows.Add(dict);
        }
    }
}
