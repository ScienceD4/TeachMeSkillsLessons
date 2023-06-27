using Core;
using NUnit.Framework;
using RestSharp;
using System.Net;

namespace ApiBL.BussinesLogic;

public static class BaseApiBL
{
    public static void AssertResponse(RestResponse resp)
    {
        if (resp.StatusCode != HttpStatusCode.OK)
        {
            LogSession.CurrentSession.Error(resp.Content!);
        }

        Assert.Multiple(() =>
        {
            Assert.That(resp.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Assert.That(resp.Content, Is.Not.Null);
            Assert.That(resp.ErrorMessage, Is.Null);
            Assert.That(resp.ErrorException, Is.Null);
        });
    }
}