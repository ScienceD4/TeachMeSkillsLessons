﻿using Common;
using Core;
using NUnit.Allure.Attributes;
using Saucedemo.Models;
using Saucedemo.PageObjects.Parameters;

namespace Saucedemo.PageObjects;

public class CheckoutPage : BasePage
{
    private readonly By fistNameInput = By.CssSelector("[data-test='firstName']");
    private readonly By lastPassInput = By.CssSelector("[data-test='lastName']");
    private readonly By postalCodeInput = By.CssSelector("[data-test='postalCode']");
    private readonly By continueButton = By.CssSelector("[data-test='continue']");
    private readonly By finishButton = By.CssSelector("[data-test='finish']");
    private readonly By backHomeButton = By.CssSelector("[data-test='back-to-products']");
    private readonly By checkoutItems = By.CssSelector(".cart_item");

    private IWebElement FistNameInput => Driver.FindElement(fistNameInput);
    private IWebElement LastPassInput => Driver.FindElement(lastPassInput);
    private IWebElement PostalCodeInput => Driver.FindElement(postalCodeInput);
    private IWebElement ContinueButton => Driver.FindElement(continueButton);
    private IWebElement FinishButton => Driver.FindElement(finishButton);
    private IWebElement BackHomeButton => Driver.FindElement(backHomeButton);
    private IReadOnlyCollection<IWebElement> CheckoutItems => Driver.FindElements(checkoutItems);

    public List<UICheckoutItem>? UICheckoutItems { get; set; }

    public CheckoutPage() : base()
    {
        Driver.WaitLoad(x => IsExist(), TIME_OUT_LOAD_PAGE);
        Browser.Instance.TakeScreenShot("Open CheckoutPage");
    }

    public CheckoutPage GetData()
    {
        UICheckoutItems = new List<UICheckoutItem>();

        if (CheckoutItems.Any())
        {
            foreach (var item in CheckoutItems)
            {
                UICheckoutItems.Add(new UICheckoutItem(item).GetData());
            }
        }

        return this;
    }

    [AllureStep]
    public CheckoutPage Continue(UserModel? user = null)
    {
        user ??= new UserModel("123", "123", "123");

        FistNameInput.SendKeys(user.FirstName);
        LastPassInput.SendKeys(user.LastName);
        PostalCodeInput.SendKeys(user.PostalCode);
        Browser.Instance.TakeScreenShot("Inputs");

        ContinueButton.Click();
        Browser.Instance.TakeScreenShot("Click Continue");

        return this;
    }

    [AllureStep]
    public CheckoutPage Finish()
    {
        FinishButton.Click();
        Browser.Instance.TakeScreenShot("Click Finish");

        return this;
    }

    [AllureStep]
    public InventoryPage BackHome()
    {
        BackHomeButton.Click();

        return new InventoryPage();
    }

    public override bool IsExist()
    {
        return ContinueButton.Displayed;
    }
}