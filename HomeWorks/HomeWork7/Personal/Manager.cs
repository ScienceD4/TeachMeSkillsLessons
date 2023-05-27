using HomeWork7.Interfaces;

namespace HomeWork7.Personal;

public class Manager : Person, IManageable, ISolvingable, ICookable
{
    public Manager(string name) : base(name)
    {
    }

    public void Manage()
    {
        Console.WriteLine("Manager is managing people");
    }

    public void CookFood()
    {
        Console.WriteLine("Manager is cooking");
    }

    public void Solving()
    {
        Console.WriteLine("Manager is solving conflicts");
    }
}