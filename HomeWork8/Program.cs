namespace HomeWork8;

internal class Program
{
    private static void Main()
    {
        var ration = RationCreator.Create();

        var person = new Person("Alex", 1500)
        {
            Ration = ration
        };

        person.Ration.PrintInfo();
    }
}