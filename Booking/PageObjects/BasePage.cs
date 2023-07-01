using Core;
using NUnit.Allure.Core;
using OpenQA.Selenium;

namespace Booking.PageObjects;

[AllureNUnit]
public class BasePage
{
    protected IWebDriver Driver { get; } = Browser.Instance.Driver;
}