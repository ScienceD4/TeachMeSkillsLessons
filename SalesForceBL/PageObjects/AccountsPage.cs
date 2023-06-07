using Common;
using SalesForceBL.Elements;
using SalesForceBL.PageObjects.ModelParams;

namespace SalesForceBL.PageObjects;

public class AccountsPage : BasePage
{
    private Button New { get; set; } = new(By.XPath("//*[@title='New']"));

    public Table AccountsTable { get; set; } = new(By.XPath("//table"));

    public AccountsPage GetData()
    {
        Driver.WaitLoad(x => new Button(By.XPath("//a[@data-refid='recordId']")).IsExist, 5_000);
        AccountsTable.GetData();

        return this;
    }

    public NewAccountForm CreateNew()
    {
        New.Click();

        return new NewAccountForm();
    }
}

public class NewAccountForm : BasePage
{
    private Input AccountName { get; set; } = new Input(By.XPath("//input[@name='Name']"));
    private Input Phone { get; set; } = new Input(By.XPath("//input[@name='Phone']"));
    private Button Save { get; set; } = new Button(By.XPath("//button[@name='SaveEdit']"));

    public void Create(NewAccountFormParams formParams)
    {
        AccountName.FillIn(formParams.AccountName);
        Phone.FillIn(formParams.Phone);
        Save.Click();
    }
}