namespace HomeWork11NUnit.Core;

public class BaseCalcTest
{
    public Calculator Calculator { get; set; }

    [OneTimeSetUp]
    public virtual void OneTimeSetup()
    {
        Console.WriteLine("- OneTimeSetUp");
        Calculator = new Calculator();
    }

    [SetUp]
    public virtual void Setup()
    {
        // Не работает((
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--- SetUp");
    }

    [TearDown]
    public virtual void TearDown()
    {
        Console.WriteLine("--- TearDown");
        Console.ResetColor();
    }

    [OneTimeTearDown]
    public virtual void OneTimeTearDown()
    {
        Console.WriteLine("- OneTimeTearDown");
    }
}