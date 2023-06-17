namespace ApiTests.Core;

public class BaseService
{
    protected BaseApiClient ApiClient { get; set; }

    public BaseService(bool withAuth, BaseApiClient apiClient)
    {
        ApiClient = apiClient;

        if (withAuth)
        { ApiClient.AddToken("b2ee7675a0ebd15d9605638fea4ab6833468e82776b3b444c7dac84fbbb5700f"); }
    }
}