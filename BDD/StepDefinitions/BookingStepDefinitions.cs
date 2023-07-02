﻿using Booking.PageObjects;
using Booking.PageObjects.PageElements;
using Core;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace BDD.StepDefinitions;

[Binding]
[AllureNUnit]
public class BookingStepDefinitions : BaseDefinitions
{
    protected BookingStepDefinitions(ScenarioContext context) : base(context)
    {
        Browser.Instance.IsSaveOnAllure = false;
    }

    [Given(@"hotel name is (.*)")]
    public void GivenHotelName(string hotelTitle)
    {
        scenarioContext["hotelTitle"] = hotelTitle;
    }

    [When(@"search hotel")]
    public void WhenSearchHotel()
    {
        var hotelName = scenarioContext.Get<string>("hotelTitle");
        var items = new SearchPage().Show().SearchHotel(hotelName).GetHotelItems();
        scenarioContext["hotelItems"] = items;
    }

    [Then(@"hotel score is (.*)")]
    public void ThenHotelScoreIs(string score)
    {
        var hotelName = scenarioContext.Get<string>("hotelTitle");
        var items = scenarioContext.Get<IEnumerable<HotelItem>>("hotelItems");

        var hotel = items.FirstOrDefault(x => x.Title.Equals(hotelName))
            ?? throw new Exception("Hotel is null");

        Assert.That(hotel.Score, Is.EqualTo(score));
    }

    [Then(@"close browser")]
    public void ThenCloseBrowser()
    {
        Browser.Instance.CloseBrowser();
    }
}