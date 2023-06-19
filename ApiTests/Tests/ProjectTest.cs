using ApiBL.BussinesLogic;
using ApiTests.BussinesObject.Models;
using ApiTests.BussinesObject.Services;
using Newtonsoft.Json.Linq;

namespace ApiTests.Tests;

[TestFixture]
public class ProjectTest : BaseApiTest
{
    [Test]
    public void GetProject()
    {
        var projectCode = "AQA01";

        var project = ProjectBL.GetProjectByCode(projectCode);

        Assert.That(project.Code, Is.EqualTo(projectCode));
    }

    [Test]
    public void GetProjects()
    {
        var projectCode = "AQA01";

        var projects = ProjectBL.GetAllProjects();

        Assert.That(projects.Select(x => x.Code), Does.Contain(projectCode));
    }

    [Test]
    public void CreateProject()
    {
        var projectCode = "QA" + DateTime.Now.ToString("ddHHmmss");

        var projectReq = new CreateProjectRequest
        {
            Code = projectCode,
            Title = "Test_" + projectCode,
        };

        var newProjectCode = ProjectBL.CreateProject(projectReq);

        Assert.That(newProjectCode, Is.EqualTo(projectCode));
    }

    [Test]
    public void CreateProjectError()
    {
        var expectedError = "Project with the same code already exists.";
        var projectCode = "AQA01";

        var projectReq = new CreateProjectRequest
        {
            Code = projectCode,
            Title = "Test",
        };

        var resp = new ProjectService().CreateProject(projectReq);

        var error = JObject.Parse(resp.Content!).SelectToken("$.errorFields[0].error")?.ToString();

        Assert.Multiple(() =>
        {
            Assert.That(resp.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.BadRequest));
            Assert.That(error, Is.EqualTo(expectedError));
        });
    }

    [Test]
    public void CreateAndDeleteProject()
    {
        var projectCode = "QA" + DateTime.Now.ToString("ddHHmmss");

        var projectReq = new CreateProjectRequest
        {
            Code = projectCode,
            Title = "Test_" + projectCode,
        };

        var newProjectCode = ProjectBL.CreateProject(projectReq);
        Assert.That(newProjectCode, Is.EqualTo(projectCode));

        var res = ProjectBL.DeleteProjectByCode(newProjectCode);
        Assert.Multiple(() =>
        {
            Assert.That(res.Status, Is.True);
            Assert.That(res.Result, Is.Null);
        });
    }

    [Test]
    public void CreateCheckAndDeleteProject()
    {
        var projectCode = "QA" + DateTime.Now.ToString("ddHHmmss");
        var projectTitle = "Test_" + projectCode;

        var projectReq = new CreateProjectRequest
        {
            Code = projectCode,
            Title = projectTitle,
        };

        var newProjectCode = ProjectBL.CreateProject(projectReq);
        Assert.That(newProjectCode, Is.EqualTo(projectCode));

        var project = ProjectBL.GetProjectByCode(projectCode);
        Assert.Multiple(() =>
        {
            Assert.That(project.Code, Is.EqualTo(projectCode));
            Assert.That(project.Title, Is.EqualTo(projectTitle));
        });

        ProjectBL.DeleteProjectByCode(projectCode);

        var projects = ProjectBL.GetAllProjects();
        Assert.That(projects.Select(x => x.Code), Does.Not.Contain(projectCode));
    }
}