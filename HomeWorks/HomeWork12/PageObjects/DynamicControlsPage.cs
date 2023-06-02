using OpenQA.Selenium;
using System.Net.Security;

namespace HomeWork12.PageObjects;

public class DynamicControlsPage : BasePage
{
    private IWebElement Link => Driver.FindElement(By.LinkText("Dynamic Controls"));
    private IWebElement CheckBox => Driver.FindElement(By.CssSelector("#checkbox>input"));
    private bool CheckBoxExist => Driver.FindElements(By.CssSelector("#checkbox>input")).Count > 0;
    private IWebElement CheckBoxMessage => Driver.FindElement(By.CssSelector("#checkbox-example>#message"));
    private IWebElement InputMessage => Driver.FindElement(By.CssSelector("#input-example>#message"));
    private IWebElement RemoveButton => Driver.FindElement(By.CssSelector("#checkbox-example>button"));
    private IWebElement EnableButton => Driver.FindElement(By.CssSelector("#input-example>button"));
    private IWebElement Input => Driver.FindElement(By.CssSelector("#input-example>input"));

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
        return CheckBox.Selected;
    }

    public bool CheckBoxIsExist()
    {
        return CheckBoxExist;
    }

    public string GetCheckBoxMessage()
    {
        return CheckBoxMessage.Text;
    }

    public string GetInputMessage()
    {
        return InputMessage.Text;
    }

    public DynamicControlsPage SetCheckBoxState(bool state)
    {
        if (CheckBoxIsChecked() != state)
        {
            CheckBox.Click();
        }

        return this;
    }

    public DynamicControlsPage RemoveCheckBox()
    {
        RemoveButton.Click();

        return this;
    }

    public bool InputIsEnable()
    {
        return Input.Enabled;
    }

    public DynamicControlsPage EnableInput()
    {
        EnableButton.Click();

        return this;
    }
}