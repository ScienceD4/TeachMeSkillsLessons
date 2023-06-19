using ApiTests.Core;

namespace ApiBL.BussinesObject.Clients;

public class QaseAppClient : BaseApiClient
{
    private const string url = "https://api.qase.io/v1/";

    public QaseAppClient(bool withAuth) : base(url)
    {
        if (withAuth)
        { AddToken("b2ee7675a0ebd15d9605638fea4ab6833468e82776b3b444c7dac84fbbb5700f"); }
    }
}