using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace HomeWork12.PageObjects;

public class ContextMenuPage : BasePage
{
    private IWebElement Link => Driver.FindElement(By.LinkText("Context Menu"));

    private IWebElement ContextBox => Driver.FindElement(By.Id("hot-spot"));

    public ContextMenuPage(WebDriver driver) : base(driver)
    {
    }

    public ContextMenuPage Show()
    {
        Open();
        Link.Click();
        return this;
    }

    public string RightClickContextBoxAndGetText()
    {
        ContextClickElement(ContextBox);
        var alert = Driver.SwitchTo().Alert();
        var text = alert.Text;
        alert.Accept();

        return text;
    }

    private void ContextClickElement(IWebElement element)
    {
        new Actions(Driver)
            .ContextClick(element)
            .Perform();
    }
}