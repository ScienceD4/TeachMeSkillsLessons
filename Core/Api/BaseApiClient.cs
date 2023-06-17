using RestSharp;

namespace ApiTests.Core;

public class BaseApiClient
{
    private RestClient client;

    public BaseApiClient(string url)
    {
        var options = new RestClientOptions(url)
        {
            MaxTimeout = 10_000,
            ThrowOnAnyError = false,
        };

        client = new RestClient(options);
        client.AddDefaultHeader("Content-Type", "application/json");
    }

    public void AddToken(string token)
    {
        client.AddDefaultHeader("Token", token);
    }

    public RestResponse Execute(RestRequest request)
    {
        return client.Execute(request);
    }
}