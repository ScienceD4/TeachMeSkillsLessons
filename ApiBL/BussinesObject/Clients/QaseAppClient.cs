using ApiTests.Core;
using Core.Settings;

namespace ApiBL.BussinesObject.Clients;

public class QaseAppClient : BaseApiClient
{
    public QaseAppClient(bool withAuth) : base(Settings.API.QaseAppUrl)
    {
        if (withAuth)
        { AddToken(Settings.API.QaseAppToken); }
    }
}