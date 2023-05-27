using OpenQA.Selenium;

namespace Saucedemo.PageObjects;

public class LoginPage : BasePage
{
    const string STANDARD_USER_NAME = "standard_user";
    const string LOCKED_OUT_USER = "locked_out_user";
    const string PROBLEM_USER = "problem_user";
    const string PERFORMANCE_GLITCH_USER = "performance_glitch_user";
    const string PASSWORD = "secret_sauce";


    readonly By userNameInput = By.CssSelector("[data-test='username']");
    readonly By userPassInput = By.CssSelector("[data-test='password']");
    readonly By loginButton = By.CssSelector("[data-test='login-button']");
    readonly By errorMessage = By.CssSelector("[data-test='error']");

    IWebElement LoginButton => Driver.FindElement(loginButton);
    IWebElement UserNameInput => Driver.FindElement(userNameInput);
    IWebElement UserPassInput => Driver.FindElement(userPassInput);
    IWebElement ErrorMessage => Driver.FindElement(errorMessage);


    public LoginPage(IWebDriver driver) : base(driver)
    {
    }

    public LoginPage Show()
    {
        Driver.Navigate().GoToUrl(url);

        return this;
    }

    public InventoryPage LoginStandardUser()
    {
        UserNameInput.SendKeys(STANDARD_USER_NAME);
        UserPassInput.SendKeys(PASSWORD);
        LoginButton.Click();

        return new InventoryPage(Driver);
    }
}
