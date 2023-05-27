using OpenQA.Selenium;

namespace Saucedemo.PageObjects;

public class LoginPage : BasePage
{
    private const string STANDARD_USER_NAME = "standard_user";
    private const string LOCKED_OUT_USER = "locked_out_user";
    private const string PROBLEM_USER = "problem_user";
    private const string PERFORMANCE_GLITCH_USER = "performance_glitch_user";
    private const string PASSWORD = "secret_sauce";

    private readonly By userNameInput = By.CssSelector("[data-test='username']");
    private readonly By userPassInput = By.CssSelector("[data-test='password']");
    private readonly By loginButton = By.CssSelector("[data-test='login-button']");
    private readonly By errorMessage = By.CssSelector("[data-test='error']");

    private IWebElement LoginButton => Driver.FindElement(loginButton);
    private IWebElement UserNameInput => Driver.FindElement(userNameInput);
    private IWebElement UserPassInput => Driver.FindElement(userPassInput);
    private IWebElement ErrorMessage => Driver.FindElement(errorMessage);

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