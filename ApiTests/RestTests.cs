using RestSharp;

namespace ApiTests;

[TestFixture]
public class RestTests
{
    RestClient client;

    [SetUp]
    public void Setup()
    {
        client = new RestClient("https://reqres.in/api");
    }

    [Test]
    public void GetProjects()
    {
        client = new RestClient();
        var request = new RestRequest("https://api.qase.io/v1/project", Method.Get);
        request.AddHeader("Token", "139648cd7fae0460f1e38bd794aaf54a22505db0680705fabe0efeb918d968c2");

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

        request.AddBody(body);

        RestResponse response = client.Execute(request);

        Console.WriteLine(response.Content);
    }
}