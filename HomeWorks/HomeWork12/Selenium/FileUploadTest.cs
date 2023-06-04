using HomeWork12.PageObjects;

namespace HomeWork12.Selenium;

[TestFixture]
public class FileUploadTest : BaseTest
{
    [Test]
    public void UploadFileTest()
    {

        var directory = Environment.CurrentDirectory + "\\TestData\\";
        var fileName = "testText.txt";

        var fullname = new FileUploadPage(Driver)
            .Show().UploadFile(directory + fileName).GetFileName();

        var name = fullname.Split("\\").Last();

        Assert.That(name, Is.EqualTo(fileName));
    }
}
