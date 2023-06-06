﻿using Common;
using SalesForce.Elements;

namespace SalesForce.PageObjects;

public class HomePage : BasePage
{
    private Span AppNameSpan { get; set; } = new Span(By.XPath("//span[contains(@class, 'appName')]"));
    private Button AppButton { get; set; } = new Button(By.XPath("//*[@class='slds-button slds-show']"));
    private Button NavigateMenu { get; set; } = new Button(By.CssSelector(".navMenu [title='Show Navigation Menu']"));
    private Button Contacts { get; set; } = new Button(By.XPath("//*[@data-id='Contact']//span"));
    private Button HomeTab { get; set; } = new Button(By.XPath("//*[@data-id='home']//span"));
    private Button Accounts { get; set; } = new Button(By.XPath("//*[@data-id='Account']//span"));

    public HomePage()
    {
        Driver.WaitLoad(x => AppNameSpan.WebElement, 10_000);
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
        Accounts.Click();

        return new AccountsPage();
    }

    public HomePage GoToSales()
    {
        AppButton.Click();
        Driver.FindElement(By.XPath("//button[@aria-label='View All Applications']")).Click();
        Driver.FindElement(By.XPath("//p[text()='Sales']")).Click();
        WaitHelper.Until(10_000, () => GetAppName() == "Sales");

        return this;
    }
}