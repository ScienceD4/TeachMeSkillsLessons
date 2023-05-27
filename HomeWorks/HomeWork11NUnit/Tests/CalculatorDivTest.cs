using HomeWork11NUnit.Core;

namespace HomeWork11NUnit.Tests;

[TestFixture]
[Category("Div")]
[Description("Division tests")]
public class CalculatorDivTest : BaseCalcTest
{
    [Test]
    [TestCase(10, 2, 5)]
    public void DivTest(int x, int y, int res)
    {
        Calculator.X = x;
        Calculator.Y = y;
        var expected = res;
        var actual = Calculator.Div();

        Assert.That(actual, Is.EqualTo(expected));
    }
}