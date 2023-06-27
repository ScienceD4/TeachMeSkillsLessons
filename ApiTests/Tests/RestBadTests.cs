using ApiTests.Models;
using Newtonsoft.Json;
using RestSharp;

namespace ApiTests.Tests;

[TestFixture]
public class RestBadTests
{
    private RestClient client;

    [SetUp]
    public void Setup()
    {
        client = new RestClient("https://reqres.in/api");
    }

    [Test]
    public void GetProjects()
    {
        client = new RestClient("https://api.qase.io/v1");
        var request = GetQaseIoRequest("/project", Method.Get);

        RestResponse response = client.Execute(request);

        Console.WriteLine(response.Content);
    }

    [Test]
    public void CreateUser()
    {
        var body = new
        {
            Name = "Dimka",
            Job = "qwerer"
        };

        var request = new RestRequest("/users", Method.Post);

        var json = JsonConvert.SerializeObject(body);

        request.AddBody(json);

        RestResponse response = client.Execute(request);

        Console.WriteLine(response.Content);
    }

    [Test]
    public void GetUserById()
    {
        var request = new RestRequest("/users/2", Method.Get);

        RestResponse response = client.Execute(request);

        var resp = JsonConvert.DeserializeObject<GetUserRequest>(response.Content);

        Console.WriteLine(response.Content);
    }

    private RestRequest GetQaseIoRequest(string resource, Method method)
    {
        var request = new RestRequest(resource, method);
        request.AddHeader("Token", "b2ee7675a0ebd15d9605638fea4ab6833468e82776b3b444c7dac84fbbb5700f");
        return request;
    }
}