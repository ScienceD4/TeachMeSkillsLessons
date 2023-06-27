using Allure.Net.Commons;
using NUnit.Allure.Core;

namespace ApiTests.Tests;

[AllureNUnit]
[TestFixture]
[Parallelizable(ParallelScope.Fixtures)]
public class BaseApiTest
{
    private AllureLifecycle allure;

    [OneTimeSetUp]
    public void Setup()
    {
        allure = AllureLifecycle.Instance;
    }
}