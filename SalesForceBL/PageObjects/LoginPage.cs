﻿using Core.Settings;
using SalesForceBL.Elements;

namespace SalesForceBL.PageObjects;

public class LoginPage : BasePage
{
    private readonly string url = Settings.SalesForce.Url;
    private readonly string USER_NAME = Settings.SalesForce.Login;
    private readonly string PASSWORD = Settings.SalesForce.Password;

    private Input UserName { get; set; } = new(By.Id("username"));
    private Input Password { get; set; } = new(By.Id("password"));
    private Button Login { get; set; } = new(By.Id("Login"));

    public LoginPage Show()
    {
        Driver.Navigate().Refresh();
        Driver.Navigate().GoToUrl(url);

        return this;
    }

    public HomePage LogIn()
    {
        UserName.FillIn(USER_NAME);
        Password.FillIn(PASSWORD);
        Login.Click();

        return new HomePage().GoToSales();
    }
}