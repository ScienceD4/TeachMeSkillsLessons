using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;

namespace HomeWork12.PageObjects;

public class HoversPage : BasePage
{
    private IWebElement Link => Driver.FindElement(By.LinkText("Hovers"));
    private ReadOnlyCollection<IWebElement> Users => Driver.FindElements(By.ClassName("figure"));

    public HoversPage(WebDriver driver) : base(driver)
    {
    }

    public HoversPage Show()
    {
        Open();
        Link.Click();

        return this;
    }

    public string ViewProfileAndGetText(int index)
    {
        var actions = new Actions(Driver);

        var user = Users[index];

        actions.MoveToElement(user).Build().Perform();

        user.FindElement(By.TagName("a")).Click();

        return Driver.FindElement(By.TagName("h1")).Text;
    }
    public string GetProfileName(int index)
    {
        var actions = new Actions(Driver);

        var user = Users[index];

        actions.MoveToElement(user).Build().Perform();

        return user.FindElement(By.TagName("h5")).Text.Split(": ")[1];
    }

    public void Back()
    {
        Driver.Navigate().Back();
    }

}
