using Common;
using Core.Settings;
using SalesForceBL.Elements;

namespace SalesForceBL.PageObjects;

public class HomePage : BasePage
{
    private Span AppNameSpan { get; set; } = new(By.XPath("//span[contains(@class, 'appName')]"));
    private Button AppButton { get; set; } = new(By.XPath("//*[@class='slds-button slds-show']"));
    private Button Contacts { get; set; } = new(By.XPath("//*[@data-id='Contact']//span"));
    private Button HomeTab { get; set; } = new(By.XPath("//*[@data-id='home']"));
    private Button Accounts { get; set; } = new(By.XPath("//*[@data-id='Account']"));
    private Button Refresh { get; set; } = new(By.XPath("//button[@title='Refresh Chart']"));

    public HomePage()
    {
        Driver.WaitLoad(x => Refresh.IsExist, Settings.Browser.TimeOutSeconds * 1000);
    }

    public ContactsPage OpenContacts()
    {
        Contacts.ClickByJava();

        return new ContactsPage();
    }

    public string GetAppName()
    {
        return AppNameSpan.Text;
    }

    public AccountsPage OpenAccounts()
    {
        Accounts.ClickWithActions();

        return new AccountsPage();
    }

    public HomePage GoToSales()
    {
        var appName = "Sales";

        if (GetAppName() == appName)
        {
            return this;
        }
        else
        {
            AppButton.Click();
            new Button(By.XPath("//button[@aria-label='View All Applications']")).Click();
            new Button(By.XPath($"//p[text()='{appName}']")).Click();
            WaitHelper.Until(10_000, () => GetAppName() == appName);

            return this;
        }
    }
}