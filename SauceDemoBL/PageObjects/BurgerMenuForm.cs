using Common;

namespace Saucedemo.PageObjects;

public class BurgerMenuForm : BasePage
{
    private readonly By allItemsLink = By.Id("inventory_sidebar_link");
    private readonly By aboutLink = By.Id("about_sidebar_link");
    private readonly By logoutLink = By.Id("logout_sidebar_link");
    private readonly By reserAppStateLink = By.Id("reset_sidebar_link");
    private readonly By menuButton = By.Id("react-burger-menu-btn");
    private readonly By closeButton = By.Id("react-burger-cross-btn");

    private IWebElement AllItemsLink => Driver.FindElement(allItemsLink);
    private IWebElement AboutLink => Driver.FindElement(aboutLink);
    private IWebElement LogoutLink => Driver.FindElement(logoutLink);
    private IWebElement ReserAppStateLink => Driver.FindElement(reserAppStateLink);
    private IWebElement MenuButton => Driver.FindElement(menuButton);
    private IWebElement CloseButton => Driver.FindElement(closeButton);

    public BurgerMenuForm(IWebDriver driver) : base(driver)
    {
    }

    public BurgerMenuForm Show()
    {
        MenuButton.Click();
        Driver.WaitLoad(x => IsExist(), TIME_OUT_LOAD_PAGE);

        return this;
    }

    public LoginPage Logout()
    {
        LogoutLink.Click();

        return new LoginPage(Driver);
    }

    public override bool IsExist()
    {
        return CloseButton.Displayed;
    }
}