using HomeWork7.Interfaces;

namespace HomeWork7.Personal;

public class Cleaner : Person, ICleanable
{
    public Cleaner(string name) : base(name)
    {
    }

    public void Clean()
    {
        Console.WriteLine("Cleaner is cleaning");
    }
}