using SalesForce.Elements;

namespace SalesForce.PageObjects;

public class HomePage : BasePage
{
    private Button NavigateMenu { get; set; } = new Button(By.CssSelector(".navMenu [title='Show Navigation Menu']"));
    private Button Contacts { get; set; } = new Button(By.CssSelector("#navMenuList [data-itemid='Contact']"));
    private Button Accounts { get; set; } = new Button(By.CssSelector("#navMenuList [data-itemid='Account']"));

    public ContactsPage OpenContacts()
    {
        NavigateMenu.Click();
        Contacts.Click();

        return new ContactsPage();
    }

    public AccountsPage OpenAccounts()
    {
        NavigateMenu.Click();
        Accounts.Click();

        return new AccountsPage();
    }
}