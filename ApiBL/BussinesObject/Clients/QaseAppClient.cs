using ApiTests.Core;

namespace ApiBL.BussinesObject.Clients;

public class QaseAppClient : BaseApiClient
{
    private const string url = "https://api.qase.io/v1/";

    public QaseAppClient() : base(url)
    {
    }
}