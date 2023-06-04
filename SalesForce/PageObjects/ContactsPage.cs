using SalesForce.Elements;

namespace SalesForce.PageObjects;

public class ContactsPage : BasePage
{
    private Button New { get; set; } = new Button(By.CssSelector("a[title='New'][role='button']"));

    public NewContactForm CreateNew()
    {
        New.Click();

        return new NewContactForm();
    }
}

public class NewContactForm : BasePage
{
    //private static readonly string cssLayoutName = "[data-input-element-id='input-field']";

    private Input FirstName { get; set; } = new Input(By.CssSelector("input[name='firstName']"));
    private Input LastName { get; set; } = new Input(By.CssSelector("input[name='lastName']"));
    private Button Save { get; set; } = new Button(By.CssSelector("button[name='SaveEdit']"));

    public void Create()
    {
        FirstName.FillIn("dimas");
        LastName.FillIn("ddddd");
        Save.Click();
    }
}