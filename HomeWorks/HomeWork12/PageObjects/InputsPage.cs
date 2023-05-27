using OpenQA.Selenium;

namespace HomeWork12.PageObjects;

public class InputsPage : BasePage
{
    private IWebElement Link => Driver.FindElement(By.LinkText("Inputs"));
    private IWebElement Input => Driver.FindElement(By.TagName("input"));

    public InputsPage(WebDriver driver) : base(driver)
    {
    }

    public InputsPage Show()
    {
        Open();
        Link.Click();

        return this;
    }

    public InputsPage SendKeys(string text)
    {
        Input.SendKeys(text);

        return this;
    }

    public string GetText()
    {
        var text = Input.Text;

        if (string.IsNullOrEmpty(text))
        {
            text = Input.GetAttribute("value");
        }

        return text;
    }

    public InputsPage Clear()
    {
        Input.Clear();

        return this;
    }
}