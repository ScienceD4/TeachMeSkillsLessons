using ApiBL.BussinesObject.Clients;
using ApiTests.BussinesObject.Models;
using Core.Api;
using Newtonsoft.Json;
using RestSharp;

namespace ApiTests.BussinesObject.Services;

public class ProjectService : BaseService
{
    private string ProjectByCodeEndpoint = "project/{code}";
    private string ProjectEndpoint = "project";

    public ProjectService(bool withAuth = true) : base(new QaseAppClient(withAuth))
    {
    }

    public RestResponse GetProjectByCode(string code)
    {
        var request = new RestRequest(ProjectByCodeEndpoint, Method.Get).AddUrlSegment("code", code);
        return ApiClient.Execute(request);
    }

    public RestResponse GetAllProjects()
    {
        var request = new RestRequest(ProjectEndpoint, Method.Get);
        return ApiClient.Execute(request);
    }

    public RestResponse CreateProject(CreateProjectRequest projectRequest)
    {
        var request = new RestRequest(ProjectEndpoint, Method.Post);
        var body = JsonConvert.SerializeObject(projectRequest);
        request.AddBody(body);

        return ApiClient.Execute(request);
    }

    public RestResponse DeleteProjectByCode(string code)
    {
        var request = new RestRequest(ProjectByCodeEndpoint, Method.Delete).AddUrlSegment("code", code);
        return ApiClient.Execute(request);
    }
}