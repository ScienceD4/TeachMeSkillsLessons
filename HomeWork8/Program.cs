namespace HomeWork8;

internal class Program
{
    private static void Main()
    {
        var ration = RationCreator.Create();

        Console.WriteLine("Ration before");
        ration.PrintInfo();

        var person = new Person("Alex", 1500, ration);

        Console.WriteLine("Person's Ration");
        person.Ration?.PrintInfo();
    }
}