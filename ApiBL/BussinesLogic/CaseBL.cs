using ApiBL.BussinesObject.Models;
using ApiTests.BussinesObject.Models;
using ApiTests.BussinesObject.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Allure.Attributes;
using RestSharp;

namespace ApiBL.BussinesLogic;

public static class CaseBL
{

    [AllureStep]
    public static List<Case> GetAllCasesByProjectCode(string code)
    {
        var response = new CaseService().GetAllCasesByProjectCode(code);
        BaseApiBL.AssertResponse(response);

        return JsonConvert.DeserializeObject<CommonData<CommonEntity<Case>>>(response.Content!)!.Result.Entities;
    }

    [AllureStep]
    public static Case GetCaseById(int id, string projectCode)
    {
        var response = new CaseService().GetCaseById(id, projectCode);
        BaseApiBL.AssertResponse(response);

        return JsonConvert.DeserializeObject<CommonData<Case>>(response.Content!)!.Result;
    }

    [AllureStep]
    public static int CreateCase(CaseCreateModel caseModel, string projectCode)
    {
        var response = new CaseService().CreateCase(caseModel, projectCode);
        BaseApiBL.AssertResponse(response);

        return int.Parse(JObject.Parse(response.Content!).SelectToken("$.result.id")!.ToString());
    }

    [AllureStep]
    public static int UpdateCase(CaseCreateModel caseModel, string projectCode, int id)
    {
        var response = new CaseService().UpdateCase(caseModel, projectCode, id);
        BaseApiBL.AssertResponse(response);

        return int.Parse(JObject.Parse(response.Content!).SelectToken("$.result.id")!.ToString());
    }

    [AllureStep]
    public static List<int> CreateCaseBulk(CreateCaseBulkRequest caseBulkRequest, string projectCode)
    {
        var response = new CaseService().CreateCaseBulk(caseBulkRequest, projectCode);
        BaseApiBL.AssertResponse(response);
        return JObject.Parse(response.Content!).SelectToken("$.result.ids")!.ToObject<List<int>>()!;
    }

    [AllureStep]
    public static int DeleteCaseById(int id, string projectCode)
    {
        var response = new CaseService().DeleteCaseById(id, projectCode);
        BaseApiBL.AssertResponse(response);

        return int.Parse(JObject.Parse(response.Content!).SelectToken("$.result.id")!.ToString());
    }
}