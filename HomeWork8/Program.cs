namespace HomeWork8;

internal class Program
{
    private static void Main()
    {
        var ration = RationCreator.Create();

        var person = new Person("Alex", 1500, ration);

        person.Ration?.PrintInfo();
    }
}