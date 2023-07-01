using Core.Settings;
using Core.WebElements;

namespace SalesForceBL.PageObjects;

public class UsersBasePage : BasePage
{
    protected Button New { get; set; } = new(By.XPath("//*[@title='New']"));
    protected Button Action { get; set; } = new(By.XPath("//td//a"));
    protected Button Edit { get; set; } = new(By.XPath("//div[@role='menu']//a[@title='Edit']"));
    protected Button Delete { get; set; } = new(By.XPath("//div[@role='menu']//a[@title='Delete']"));
    protected Button ConfirmDelete { get; set; } = new(By.XPath("//button[@title='Delete']//span"));
    protected Button Refresh { get; set; } = new(By.XPath("//button[@name='refreshButton']"));
    protected Table UsersTable { get; set; } = new(By.XPath("//table"));

    public UsersBasePage()
    {
        Wait(x => Refresh.IsExist, Settings.Browser.TimeOutSeconds * 1000);
    }
}