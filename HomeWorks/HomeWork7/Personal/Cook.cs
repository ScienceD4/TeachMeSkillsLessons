using HomeWork7.Interfaces;

namespace HomeWork7.Personal;

public class Cook : Person, ICookable, ICleanable
{
    public Cook(string name) : base(name)
    {
    }

    public void Clean()
    {
        Console.WriteLine("Cook is cleaning");
    }

    public void CookFood()
    {
        Console.WriteLine("Cook is cooking");
    }
}