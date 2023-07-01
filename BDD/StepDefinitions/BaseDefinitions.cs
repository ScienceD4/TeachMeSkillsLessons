using Allure.Net.Commons;
using NUnit.Allure.Core;

namespace BDD.StepDefinitions;

[AllureNUnit]
public class BaseDefinitions
{
    protected readonly ScenarioContext scenarioContext;
    protected AllureLifecycle allure;

    protected BaseDefinitions(ScenarioContext context)
    {
        scenarioContext = context;
        allure = AllureLifecycle.Instance;
    }
}