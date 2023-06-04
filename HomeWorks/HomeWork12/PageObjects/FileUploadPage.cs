using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace HomeWork12.PageObjects;

public class FileUploadPage : BasePage
{
    private IWebElement Link => Driver.FindElement(By.LinkText("File Upload"));
    private IWebElement UploadButton => Driver.FindElement(By.Id("file-upload"));

    public FileUploadPage(WebDriver driver) : base(driver)
    {
    }

    public FileUploadPage Show()
    {
        Open();
        Link.Click();

        return this;
    }

    public FileUploadPage UploadFile(string filePath)
    {
        UploadButton.SendKeys(filePath);

        return this;
    }

    public string GetFileName()
    {
        return UploadButton.GetAttribute("value");
    }
}