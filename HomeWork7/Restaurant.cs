using HomeWork7.Interfaces;
using HomeWork7.Personal;

namespace HomeWork7;

public class Restaurant
{
    public string Title { get; set; }
    public List<Person> Staff { get; set; }

    public Restaurant(string title, List<Person> staff)
    {
        Title = title;
        Staff = staff;
    }

    public void Run()
    {
        foreach (var person in Staff)
        {
            DoWork(person);
        }
    }

    private static void DoWork(Person person)
    {
        if (person is ICleanable cleaner)
        {
            cleaner.Clean();
        }

        if (person is IManageable manager)
        {
            manager.Manage();
        }

        if (person is ICookable cook)
        {
            cook.CookFood();
        }

        if (person is ISolvingable solvingable)
        {
            solvingable.Solving();
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine(this);

        foreach (var person in Staff)
        {
            Console.WriteLine(person);
        }
    }

    public override string ToString()
    {
        return "Restaurant " + Title;
    }
}