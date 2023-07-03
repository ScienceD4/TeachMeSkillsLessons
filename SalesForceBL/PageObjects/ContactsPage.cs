using Core.WebElements;
using SalesForceBL.PageObjects.ModelParams;

namespace SalesForceBL.PageObjects;

public class ContactsPage : UsersBasePage
{
    public Table ContactsTable => UsersTable;

    public ContactsPage GetData()
    {
        ContactsTable.GetData();

        return this;
    }

    public NewContactForm CreateNew()
    {
        New.Click();

        return new NewContactForm();
    }

    public NewContactForm EditItem()
    {
        Action.ClickWithActions();
        Edit.Click();

        return new NewContactForm();
    }

    public NewContactForm DeleteItem()
    {
        Action.ClickWithActions();
        Delete.Click();
        ConfirmDelete.Click();

        return new NewContactForm();
    }
}

public class NewContactForm : BasePage
{
    private Input FirstName { get; set; } = new Input(By.XPath("//input[@name='firstName']"));
    private Input LastName { get; set; } = new Input(By.XPath("//input[@name='lastName']"));
    private Button Save { get; set; } = new Button(By.XPath("//button[@name='SaveEdit']"));

    public void FillIn(NewContactFormParams formParams)
    {
        FirstName.FillIn(formParams.FirstName);
        LastName.FillIn(formParams.LastName);
        Save.Click();
    }
}