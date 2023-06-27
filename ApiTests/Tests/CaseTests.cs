using ApiBL.BussinesLogic;
using ApiBL.BussinesObject.Models;

namespace ApiTests.Tests;

[TestFixture]
public class CaseTests : BaseApiTest
{
    private const string mainProjectCode = "AQA01";
    private static string CaseTitle => "CaseTitle_" + DateTime.Now.ToString("yyddHHmm");
    private static string CaseDescription => "Description" + CaseTitle;
    private static List<string> CaseTags => new() { "Smoke" };

    [Test]
    public void GetCase()
    {
        var caseId = 1;

        var caseModel = CaseBL.GetCaseById(caseId, mainProjectCode);

        Assert.Multiple(() =>
        {
            Assert.That(caseModel, Is.Not.Null);
            Assert.That(caseModel.Id, Is.EqualTo(caseId));
        });
    }

    [Test]
    public void CreateAndCheckCase()
    {
        var title = CaseTitle;
        var description = CaseDescription;

        var caseModel = new CaseCreateModel
        {
            Title = title,
            Description = description,
            Tags = CaseTags
        };

        var caseId = CaseBL.CreateCase(caseModel, mainProjectCode);

        Assert.That(caseId, Is.GreaterThan(0));

        var newCase = CaseBL.GetCaseById(caseId, mainProjectCode);

        Assert.Multiple(() =>
        {
            Assert.That(newCase.Title, Is.EqualTo(title));
            Assert.That(newCase.Description, Is.EqualTo(description));
            Assert.That(newCase.Tags, Is.Not.Null);
            Assert.That(newCase.Tags!.Select(t => t.Title), Is.EquivalentTo(CaseTags));
        });
    }

    [Test]
    public void GetAllCases()
    {
        var caseModels = CaseBL.GetAllCasesByProjectCode(mainProjectCode);

        Assert.Multiple(() =>
        {
            Assert.That(caseModels, Is.Not.Null);
            Assert.That(caseModels, Has.All.Not.Null);
            Assert.That(caseModels, Has.Count.GreaterThan(0));
            Assert.That(caseModels.Select(c => c.Title), Is.All.Not.Empty);
            Assert.That(caseModels.Select(c => c.Id), Is.All.GreaterThan(0));
        });
    }

    [Test]
    public void CreateAndDeleteCase()
    {
        var caseModel = new CaseCreateModel
        {
            Title = CaseTitle,
            Description = CaseDescription,
            Tags = CaseTags
        };

        var caseId = CaseBL.CreateCase(caseModel, mainProjectCode);
        Assert.That(caseId, Is.GreaterThan(0));

        var deletedCaseId = CaseBL.DeleteCaseById(caseId, mainProjectCode);
        Assert.That(deletedCaseId, Is.EqualTo(caseId));
    }

    [Test]
    public void CreateUpdateAndCheckCase()
    {
        var title = CaseTitle;
        var description = CaseDescription;

        var caseId = CaseBL.CreateCase(
            new CaseCreateModel
            {
                Title = title,
                Description = description,
                Tags = CaseTags
            },
            mainProjectCode);
        Assert.That(caseId, Is.GreaterThan(0));

        title += "UP";
        var updatedCaseId = CaseBL.UpdateCase(
            new CaseCreateModel
            {
                Title = title
            },
            mainProjectCode, caseId);
        Assert.That(updatedCaseId, Is.EqualTo(caseId));

        var newCase = CaseBL.GetCaseById(updatedCaseId, mainProjectCode);

        Assert.Multiple(() =>
        {
            Assert.That(newCase.Title, Is.EqualTo(title));
            Assert.That(newCase.Description, Is.EqualTo(description));
            Assert.That(newCase.Tags, Is.Not.Null);
            Assert.That(newCase.Tags!.Select(t => t.Title), Is.EquivalentTo(CaseTags));
        });
    }

    [Test]
    public void CreateCaseBulk()
    {
        var caseBulkModel = new CreateCaseBulkRequest
        {
            Cases = new List<CaseCreateModel>()
            {
                new()
                {
                    Title = CaseTitle,
                    Description = CaseDescription,
                    Tags = CaseTags
                }
            }
        };

        var casesId = CaseBL.CreateCaseBulk(caseBulkModel, mainProjectCode);

        Assert.That(casesId, Has.All.GreaterThan(0));
    }
}