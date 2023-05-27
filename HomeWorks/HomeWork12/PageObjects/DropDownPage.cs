using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HomeWork12.PageObjects;

public class DropDownPage : BasePage
{
    private IWebElement Link => Driver.FindElement(By.LinkText("Dropdown"));
    private IWebElement Selector => Driver.FindElement(By.Id("dropdown"));

    public DropDownPage(WebDriver driver) : base(driver)
    {
    }

    public DropDownPage Show()
    {
        Open();
        Link.Click();

        return this;
    }

    public int CountElements()
    {
        var selector = new SelectElement(Selector);

        return selector.Options.Count;
    }

    public DropDownPage SelectElement(int index)
    {
        var selector = new SelectElement(Selector);
        selector.SelectByIndex(index);

        return this;
    }

    public bool ElementIsSelected(int index)
    {
        var selector = new SelectElement(Selector);
        var element = selector.Options[index];

        return IsSelected(element);
    }

    private static bool IsSelected(IWebElement element)
    {
        return (element.GetAttribute("selected") == "true");
    }
}