using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace HomeWork12.PageObjects;

public class FileDownloadPage : BasePage
{
    private IWebElement Link => Driver.FindElement(By.LinkText("File Download"));
    private ReadOnlyCollection<IWebElement> Files => Driver.FindElements(By.CssSelector("div.example>a"));

    public FileDownloadPage(WebDriver driver) : base(driver)
    {
    }

    public FileDownloadPage Show()
    {
        Open();
        Link.Click();

        return this;
    }

    public string DownloadRandomFileAndGetName()
    {
        var random = new Random();

        var index = random.Next(Files.Count);
        var file = Files[index];
        var text = file.Text;

        file.Click();

        return text;
    }
}