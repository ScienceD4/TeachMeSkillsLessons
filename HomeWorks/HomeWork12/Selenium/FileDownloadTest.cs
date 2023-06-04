using HomeWork12.PageObjects;

namespace HomeWork12.Selenium;

[TestFixture]
public class FileDownloadTest : BaseTest
{
    //[Test]
    [Obsolete("Не работает в режиме '--headless'")]
    public void DownloadFileTest()
    {
        var filename = new FileDownloadPage(Driver).Show().DownloadRandomFileAndGetName();

        var path = Environment.CurrentDirectory + "\\download\\" + filename;

        var timeout = DateTime.Now.AddSeconds(10);
        while (DateTime.Now < timeout)
        {
            if (File.Exists(path))
            {
                break;
            }
        }

        FileAssert.Exists(path);
        File.Delete(path);
    }
}
