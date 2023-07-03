using OpenQA.Selenium;

namespace Booking.PageObjects.PageElements;

public class HotelItem
{
    private ISearchContext searchContext;

    private IWebElement TitleElement => searchContext.FindElement(By.XPath("//div[@data-testid='title']"));
    private IWebElement ScoreElement => searchContext.FindElement(By.XPath("//div[@data-testid='review-score']/child::div"));

    public string Title { get; }
    public string Score { get; }

    public HotelItem(ISearchContext searchContext)
    {
        this.searchContext = searchContext;

        Title = TitleElement.Text;
        Score = ScoreElement.Text;
    }
}