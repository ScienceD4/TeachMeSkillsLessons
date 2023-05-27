using HomeWork11NUnit.Core;

namespace HomeWork11NUnit.Tests;

[TestFixture]
[Category("Sub")]
[Description("Subtraction tests")]
public class CalculatorSubTest : BaseCalcTest
{
    [Test]
    [TestCase(4, 2, 2)]
    public void SubTest(int x, int y, int res)
    {
        Calculator.X = x;
        Calculator.Y = y;
        var expected = res;
        var actual = Calculator.Sub();

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void SubNegativeTest([Values(3, 7, 2)] int x, [Random(1, 5, 3)] int y)
    {
        Calculator.X = x;
        Calculator.Y = y;
        var expected = 15;
        var actual = Calculator.Sub();

        Assert.That(actual, Is.Not.EqualTo(expected));
    }

    [Test]
    [TestCase(0, 5)]
    [TestCase(0, 10)]
    [TestCase(0, 50)]
    [Retry(1000)]
    public void SubRandomTest(int min, int max)
    {
        var rand = new Random();
        Calculator.X = rand.Next(min, max);
        Calculator.Y = rand.Next(min, max);
        var expected = rand.Next(min, max);
        var actual = Calculator.Sub();

        Assert.That(actual, Is.LessThan(expected));
    }
}