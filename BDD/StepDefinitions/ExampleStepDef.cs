using NUnit.Framework;

namespace BDD.StepDefinitions;

[Binding]
public sealed class ExampleStepDef : BaseDefinitions
{
    private List<int> numbers = new List<int>();
    private int result;

    public ExampleStepDef(ScenarioContext context) : base(context)
    {
    }

    [Given(@"the .+ number is ([0-9]+)")]
    public void GivenTheNumber(int number)
    {
        numbers.Add(number);
        Console.WriteLine(number);
    }

    [When(@"the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        result = numbers.Sum();
        Console.WriteLine("added");
    }

    [Then(@"the result should be (.*)")]
    public void ThenTheResultShouldBe(int p0)
    {
        Assert.AreEqual(p0, result);
    }
}