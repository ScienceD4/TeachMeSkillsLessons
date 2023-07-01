using Core;
using Core.Common;
using NUnit.Allure.Attributes;

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

    public BurgerMenuForm() : base()
    {
    }

    [AllureStep]
    public BurgerMenuForm Show()
    {
        MenuButton.Click();
        Driver.WaitLoad(x => IsExist(), TIME_OUT_LOAD_PAGE);
        Browser.Instance.TakeScreenShot("Open BurgerMenu");

        return this;
    }

    [AllureStep]
    public LoginPage Logout()
    {
        LogoutLink.Click();
        Browser.Instance.TakeScreenShot("Click Logout");

        return new LoginPage();
    }

    public override bool IsExist()
    {
        return CloseButton.Displayed;
    }
}