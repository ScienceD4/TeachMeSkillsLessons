using Core;
using OpenQA.Selenium;

namespace Booking.PageObjects;

public class BasePage
{
    protected IWebDriver Driver { get; } = Browser.Instance.Driver;
}