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
            .Create(contactParams);
    }

}