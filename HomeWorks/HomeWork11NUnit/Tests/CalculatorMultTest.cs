using HomeWork11NUnit.Core;

namespace HomeWork11NUnit.Tests;

[TestFixture]
[Category("Mult")]
[Description("Multiplication tests")]
public class CalculatorMultTest : BaseCalcTest
{
    [Test]
    [TestCase(2, 2, 4)]
    public void MultTest(int x, int y, int res)
    {
        Calculator.X = x;
        Calculator.Y = y;
        var expected = res;
        var actual = Calculator.Mult();

        Assert.That(actual, Is.EqualTo(expected));
    }
}