using OpenQA.Selenium;

namespace HomeWork12.PageObjects;

public class NotificationPage : BasePage
{
    private IWebElement Link => Driver.FindElement(By.LinkText("Notification Messages"));
    private IWebElement ClickLink => Driver.FindElement(By.LinkText("Click here"));
    private IWebElement Notification => Driver.FindElement(By.Id("flash"));



    public NotificationPage(WebDriver driver) : base(driver)
    {
    }

    public NotificationPage Show()
    {
        Open();
        Link.Click();

        return this;
    }

    public NotificationPage Click()
    {
        ClickLink.Click();

        return this;
    }

    public string GetTextNotification()
    {
        var text = Notification.Text;
        return text.Remove(text.IndexOf("\r\n"));
    }
}
