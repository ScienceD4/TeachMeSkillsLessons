using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace HomeWork12.PageObjects;

public class AddRemovePage : BasePage
{
    private IWebElement Link => Driver.FindElement(By.LinkText("Add/Remove Elements"));
    private IWebElement ButtonAdd => Driver.FindElement(By.XPath("//button[text()='Add Element']"));
    private IWebElement ButtonDel => Driver.FindElement(By.XPath("//button[text()='Delete']"));
    private ReadOnlyCollection<IWebElement> Buttons => Driver.FindElements(By.TagName("button"));

    public AddRemovePage(WebDriver driver) : base(driver)
    {
    }

    public AddRemovePage Show()
    {
        Open();
        Link.Click();

        return this;
    }

    public AddRemovePage AddElement()
    {
        ButtonAdd.Click();

        return this;
    }

    public AddRemovePage DelElement()
    {
        ButtonDel.Click();

        return this;
    }

    public int CountElements()
    {
        return Buttons.Count;
    }
}