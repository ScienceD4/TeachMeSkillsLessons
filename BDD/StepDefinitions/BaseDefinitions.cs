using Core;

namespace BDD.StepDefinitions;

public class BaseDefinitions
{
    protected readonly ScenarioContext scenarioContext;

    protected BaseDefinitions(ScenarioContext context)
    {
        scenarioContext = context;
        Browser.Instance.IsNUnit = false;
    }
}