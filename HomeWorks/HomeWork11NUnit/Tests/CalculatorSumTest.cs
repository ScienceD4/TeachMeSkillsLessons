using HomeWork11NUnit.Core;

namespace HomeWork11NUnit.Tests;

[TestFixture]
[Category("Sum")]
public class CalculatorSumTest : BaseCalcTest
{
    [Test]
    [TestCase(2, 2, 4)]
    public void SumTest(int x, int y, int res)
    {
        Calculator.X = x;
        Calculator.Y = y;
        var expected = res;
        var actual = Calculator.Sum();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void SumNegativeTest([Range(3, 7, 2)] int x, [Random(1, 5, 3)] int y)
    {
        Calculator.X = x;
        Calculator.Y = y;
        var expected = 0;
        var actual = Calculator.Sum();

        Assert.That(actual, Is.Not.EqualTo(expected));
    }
}