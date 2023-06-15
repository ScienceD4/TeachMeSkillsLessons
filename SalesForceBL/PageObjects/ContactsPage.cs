using OpenQA.Selenium;
using SalesForceBL.Elements;
using SalesForceBL.PageObjects.ModelParams;

namespace SalesForceBL.PageObjects;

public class ContactsPage : BasePage
{
    private Button New { get; set; } = new (By.XPath("//*[@title='New']"));
    private Table ContactsTable { get; set; } = new(By.XPath("//table"));

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
}

public class NewContactForm : BasePage
{
    private Input FirstName { get; set; } = new Input(By.XPath("//input[@name='firstName']"));
    private Input LastName { get; set; } = new Input(By.XPath("//input[@name='lastName']"));
    private Button Save { get; set; } = new Button(By.XPath("//button[@name='SaveEdit']"));

    public void Create(NewContactFormParams formParams)
    {
        FirstName.FillIn(formParams.FirstName);
        LastName.FillIn(formParams.LastName);
        Save.Click();
    }
}