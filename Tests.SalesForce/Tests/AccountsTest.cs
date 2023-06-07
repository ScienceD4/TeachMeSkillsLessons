using Core.Common;
using SalesForceBL.PageObjects.ModelParams;

namespace Tests.SalesForce.Tests;

[TestFixture]
public class AccountsTest : BaseTest
{
    [Test]
    public void CreateNewAccount()
    {
        var accountParams = new NewAccountFormParams
        {
            AccountName = DataGenerator.GetRandomFullName(),
            Phone = DataGenerator.GetRandomPhone(),
        };

        new LoginPage()
            .Show()
            .LogIn()
            .OpenAccounts()
            .CreateNew()
            .Create(accountParams);

        var table = new HomePage().OpenAccounts().GetData().AccountsTable;

        var isContains = table.Rows
            .Any(r => r[table.Columns[2]] == accountParams.AccountName
                && r[table.Columns[4]] == accountParams.Phone);

        Assert.That(isContains, Is.True);
    }

}