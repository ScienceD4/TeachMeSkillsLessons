using OpenQA.Selenium;
using System.Net.Security;

namespace HomeWork12.PageObjects;

public class DynamicControlsPage : BasePage
{
    private IWebElement Link => Driver.FindElement(By.LinkText("Dynamic Controls"));
    private IWebElement? CheckBox => Driver.FindElements(By.CssSelector("#checkbox>input")).FirstOrDefault();
    private IWebElement CheckBoxMessage => Driver.FindElement(By.CssSelector("#checkbox-example>#message"));
    private IWebElement RemoveButton => Driver.FindElement(By.CssSelector("#checkbox-example>button"));
    private IWebElement EnableButton => Driver.FindElement(By.CssSelector("#input-example>button"));


    public DynamicControlsPage(WebDriver driver) : base(driver)
    {
    }

    public DynamicControlsPage Show()
    {
        Open();
        Link.Click();

        return this;
    }

    public bool CheckBoxIsChecked()
    {
        return CheckBox?.Selected ?? false;
    }

    public bool CheckBoxIsExist()
    {
        return CheckBox is not null;
    }

    public string GetCheckBoxMessage()
    {
        return CheckBoxMessage.Text;
    }

    public DynamicControlsPage SetCheckBoxState(bool state)
    {
        if (CheckBoxIsChecked() != state)
        {
            CheckBox.Click();
        }

        return this;
    }
}