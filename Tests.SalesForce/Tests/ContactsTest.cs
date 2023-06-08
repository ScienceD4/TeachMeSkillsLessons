using Core.Common;
using SalesForceBL.PageObjects.ModelParams;

namespace Tests.SalesForce.Tests;

[TestFixture]
public class ContactsTest : BaseTest
{
    [Test]
    public void CreateNewContact()
    {
        var contactParams = new NewContactFormParams
        {
            FirstName = DataGenerator.GetRandomFirstName(),
            LastName = DataGenerator.GetRandomLastName(),
        };

        new LoginPage()
            .Show()
            .LogIn()
            .OpenContacts()
            .CreateNew()
            .FillIn(contactParams);
    }

    [Test]
    public void EditContact()
    {
        var accountParams = new NewContactFormParams
        {
            FirstName = DataGenerator.GetRandomFirstName(),
            LastName = DataGenerator.GetRandomLastName(),
        };

        new LoginPage()
            .Show()
            .LogIn()
            .OpenContacts()
            .EditItem()
            .FillIn(accountParams);
    }

    [Test]
    public void DeleteContact()
    {
        new LoginPage()
            .Show()
            .LogIn()
            .OpenContacts()
            .DeleteItem();
    }
}