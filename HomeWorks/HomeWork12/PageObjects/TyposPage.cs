using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace HomeWork12.PageObjects;

public class TyposPage : BasePage
{
    private IWebElement Link => Driver.FindElement(By.LinkText("Typos"));
    private ReadOnlyCollection<IWebElement> Paragraphs => Driver.FindElements(By.TagName("p"));

    public TyposPage(WebDriver driver) : base(driver)
    {
    }

    public TyposPage Show()
    {
        Open();
        Link.Click();

        return this;
    }

    public TyposPage Refresh()
    {
        Driver.Navigate().Refresh();

        return this;
    }

    public List<string> GetParagraphs()
    {
        return Paragraphs.Select(p => p.Text).ToList();
    }
}