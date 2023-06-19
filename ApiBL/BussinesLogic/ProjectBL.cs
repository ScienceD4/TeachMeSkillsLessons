using ApiTests.BussinesObject.Models;
using ApiTests.BussinesObject.Services;
using Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace ApiBL.BussinesLogic;

public static class ProjectBL
{
    [AllureStep]
    public static Project GetProjectByCode(string code)
    {
        var resp = new ProjectService().GetProjectByCode(code);

        BaseApiBL.AssertResponse(resp);

        return JsonConvert.DeserializeObject<CommonData<Project>>(resp.Content!)!.Result;
    }

    [AllureStep]
    public static List<Project> GetAllProjects()
    {
        var resp = new ProjectService().GetAllProjects();

        BaseApiBL.AssertResponse(resp);

        return JsonConvert.DeserializeObject<CommonData<CommonEntity<Project>>>(resp.Content!)!.Result.Entities;
    }

    [AllureStep]
    public static string CreateProject(CreateProjectRequest projectRequest)
    {
        var resp = new ProjectService().CreateProject(projectRequest);

        BaseApiBL.AssertResponse(resp);

        return JObject.Parse(resp.Content!).SelectToken("$.result.code")!.ToString();
    }

    [AllureStep]
    public static CommonData<string> DeleteProjectByCode(string code)
    {
        var resp = new ProjectService().DeleteProjectByCode(code);

        BaseApiBL.AssertResponse(resp);

        return JsonConvert.DeserializeObject<CommonData<string>>(resp.Content!)!;
    }
}