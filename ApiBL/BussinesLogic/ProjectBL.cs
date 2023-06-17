using ApiTests.BussinesObject.Models;
using ApiTests.BussinesObject.Services;
using Core;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace ApiBL.BussinesLogic;

public static class ProjectBL
{
    private static void AssertResponse(RestResponse resp)
    {
        if (resp.StatusCode != HttpStatusCode.OK)
        {
            LogSession.CurrentSession.Error(resp.Content!);
        }

        Assert.Multiple(() =>
        {
            Assert.That(resp.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(resp.Content, Is.Not.Null);
            Assert.That(resp.ErrorMessage, Is.Null);
            Assert.That(resp.ErrorException, Is.Null);
        });
    }

    public static Project GetProjectByCode(string code)
    {
        var resp = new ProjectService().GetProjectByCode(code);

        AssertResponse(resp);

        return JsonConvert.DeserializeObject<CommonData<Project>>(resp.Content!)!.Result;
    }

    public static List<Project> GetAllProjects()
    {
        var resp = new ProjectService().GetAllProjects();

        AssertResponse(resp);

        return JsonConvert.DeserializeObject<CommonData<CommonEntity<Project>>>(resp.Content!)!.Result.Entities;
    }

    public static Project CreateProject(CreateProjectRequest projectRequest)
    {
        var resp = new ProjectService().CreateProject(projectRequest);

        AssertResponse(resp);

        return JsonConvert.DeserializeObject<CommonData<Project>>(resp.Content!)!.Result;
    }

    public static CommonData<string> DeleteProjectByCode(string code)
    {
        var resp = new ProjectService().DeleteProjectByCode(code);

        AssertResponse(resp);

        return JsonConvert.DeserializeObject<CommonData<string>>(resp.Content!)!;
    }
}