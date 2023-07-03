using Booking.PageObjects.PageElements;
using Core;
using Core.Common;
using Core.WebElements;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Booking.PageObjects;

public class SearchPage : BasePage
{
    private const string url = "https://www.booking.com/searchresults.en-gb.html";

    private Button SearchButton { get; set; } = new(By.XPath("//button[@type='submit']"));
    private Button AutoCompleteButton { get; set; } = new(By.XPath("//div[@data-testid='autocomplete-result']//div"));
    private Button DateButton { get; set; } = new(By.XPath("//button[@data-testid='date-display-field-start']"));
    private Input SearchInput { get; set; } = new(By.XPath("//div[@data-testid='destination-container']//input[@name='ss']"));
    private ReadOnlyCollection<IWebElement> HotelWebElements => Driver.FindElements(By.XPath("//div[@data-testid='property-card']"));


    public SearchPage Show()
    {
        Driver.Navigate().GoToUrl(url);
        Driver.WaitLoad(
            x => SearchInput.IsExist,
            Core.Settings.Settings.Browser.TimeOutSeconds * 1000 / 6);
        Browser.Instance.TakeScreenShot("Open Booking");

        return this;
    }

    public SearchPage SearchHotel(string hotelName)
    {
        Console.WriteLine(Driver.Url);
        SearchInput.FillIn(hotelName);
        Browser.Instance.TakeScreenShot("FillIn input");
        // Там какой то баг на сайте, нельзя очень быстро кликать на поиск, пока оставил так, не знаю, как нормально делать паузы
        Thread.Sleep(3000);
        Browser.Instance.TakeScreenShot("Wait input");
        AutoCompleteButton.Click();
        Browser.Instance.TakeScreenShot("AutoComplete Click");
        FillInDate();
        SearchButton.Click();
        Browser.Instance.TakeScreenShot("Wait loading");

        Console.WriteLine(Driver.Url);

        Driver.WaitLoad(
            x => HotelWebElements.Count > 0,
            Core.Settings.Settings.Browser.TimeOutSeconds * 1000 / 6);
        Browser.Instance.TakeScreenShot("Loaded");

        return this;
    }

    public IEnumerable<HotelItem> GetHotelItems()
    {
        foreach (var element in HotelWebElements)
        {
            yield return new HotelItem(element);
        }
    }

    private void FillInDate()
    {
        // //span[@data-date='2023-07-05']//parent::td
        var dateFrom = DateTime.Now.AddDays(2).ToString("yyyy-MM-dd");
        var dateTo = DateTime.Now.AddDays(4).ToString("yyyy-MM-dd");

        DateButton.Click();
        new Button(By.XPath($"//*[@data-date='{dateFrom}']")).Click();
        new Button(By.XPath($"//*[@data-date='{dateTo}']")).Click();

        Browser.Instance.TakeScreenShot("FillIn Date");
    }
}