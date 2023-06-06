using Common;
using SalesForce.Elements;
using System;

namespace SalesForce.PageObjects;

public class LoginPage : BasePage
{
    private readonly string url = "https://companyy2-dev-ed.develop.lightning.force.com/lightning/page/home";
    private readonly string USER_NAME = TestContext.Parameters.Get("Login");
    private readonly string PASSWORD = TestContext.Parameters.Get("Password");

    private Input UserName { get; set; } = new Input(By.Id("username"));
    private Input Password { get; set; } = new Input(By.Id("password"));
    private Button Login { get; set; } = new Button(By.Id("Login"));


    public LoginPage Show()
    {
        Driver.Navigate().GoToUrl(url);

        return this;
    }

    public HomePage LogIn()
    {
        UserName.FillIn(USER_NAME);
        Password.FillIn(PASSWORD);
        Login.Click();

        var page = new HomePage();

        if (page.GetAppName() == "Sales")
        {
            return page;
        }
        else
        {
            return page.GoToSales();
        }
    }
}