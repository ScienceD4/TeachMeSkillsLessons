using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace HomeWork12.PageObjects;

public class CheckBoxesPage : BasePage
{
    private IWebElement Link => Driver.FindElement(By.LinkText("Checkboxes"));
    private ReadOnlyCollection<IWebElement> CheckBoxes => Driver.FindElements(By.CssSelector("[type = checkbox]"));

    public CheckBoxesPage(WebDriver driver) : base(driver)
    {
    }

    public CheckBoxesPage Show()
    {
        Open();
        Link.Click();

        return this;
    }

    public bool CheckBoxIsChecked(int index)
    {
        var checkBox = CheckBoxes[index];

        return IsChecked(checkBox);
    }

    public CheckBoxesPage SetCheckBoxState(int index, bool state)
    {
        var checkbox = CheckBoxes[index];
        Set(checkbox, state);

        return this;
    }

    private static bool IsChecked(IWebElement checkBox)
    {
        return (checkBox.Selected || checkBox.GetAttribute("checked")?.ToLower() == "true");
    }

    private static void Set(IWebElement checkBox, bool state)
    {
        if (IsChecked(checkBox) != state)
        {
            checkBox.Click();
        }
    }
}