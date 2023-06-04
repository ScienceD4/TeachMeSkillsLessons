using SalesForce.PageObjects;

namespace SalesForce.Tests;
public class ContactsTest :BaseTest
{
    [Test]
    public void CreateNewContact()
    {
        new LoginPage()
            .Show()
            .LogIn()
            .OpenContacts()
            .CreateNew()
            .Create();
    }

}