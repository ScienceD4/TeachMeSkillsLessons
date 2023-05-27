using OpenQA.Selenium;

namespace HomeWork12.PageObjects;

public class BasePage
{
    private const string url = "https://the-internet.herokuapp.com/";

    protected WebDriver Driver { get; set; }

    protected BasePage(WebDriver driver)
    {
        Driver = driver;
    }

    protected void Open()
    {
        Driver.Navigate().GoToUrl(url);
    }
}