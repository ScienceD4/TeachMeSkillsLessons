using ApiBL.BussinesObject.Clients;
using ApiBL.BussinesObject.Models;
using ApiTests.Core;
using Newtonsoft.Json;
using RestSharp;

namespace ApiTests.BussinesObject.Services;

public class CaseService : BaseService
{
    private string CasesByCodeEndpoint = "case/{code}";
    private string CasesBulkEndpoint = "case/{code}/bulk";
    private string CaseByIdEndpoint = "case/{code}/{id}";

    public CaseService(bool withAuth = true) : base(new QaseAppClient(withAuth))
    {
    }

    public RestResponse GetAllCasesByProjectCode(string code)
    {
        var request = new RestRequest(CasesByCodeEndpoint, Method.Get).AddUrlSegment("code", code);

        return ApiClient.Execute(request);
    }

    public RestResponse GetCaseById(int id, string projectCode)
    {
        var request = new RestRequest(CaseByIdEndpoint, Method.Get)
            .AddUrlSegment("code", projectCode)
            .AddUrlSegment("id", id);

        return ApiClient.Execute(request);
    }

    public RestResponse CreateCase(CaseCreateModel caseModel, string projectCode)
    {
        var request = new RestRequest(CasesByCodeEndpoint, Method.Post).AddUrlSegment("code", projectCode);
        var body = JsonConvert.SerializeObject(caseModel);
        request.AddBody(body);

        return ApiClient.Execute(request);
    }

    public RestResponse UpdateCase(CaseCreateModel caseModel, string projectCode, int id)
    {
        var request = new RestRequest(CaseByIdEndpoint, Method.Patch)
            .AddUrlSegment("code", projectCode)
            .AddUrlSegment("id", id);

        var body = JsonConvert.SerializeObject(caseModel);
        request.AddBody(body);

        return ApiClient.Execute(request);
    }

    public RestResponse CreateCaseBulk(CreateCaseBulkRequest caseBulkRequest, string projectCode)
    {
        var request = new RestRequest(CasesBulkEndpoint, Method.Post).AddUrlSegment("code", projectCode);
        var body = JsonConvert.SerializeObject(caseBulkRequest);
        request.AddBody(body);

        return ApiClient.Execute(request);
    }

    public RestResponse DeleteCaseById(int id, string projectCode)
    {
        var request = new RestRequest(CaseByIdEndpoint, Method.Delete)
            .AddUrlSegment("code", projectCode)
            .AddUrlSegment("id", id);

        return ApiClient.Execute(request);
    }
}