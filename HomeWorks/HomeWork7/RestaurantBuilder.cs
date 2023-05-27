using HomeWork7.Personal;

namespace HomeWork7;

public class RestaurantBuilder
{
    private readonly List<string> names = new()
    {
        "Emily", "Michael", "Joshua", "Matthew", "Ethan", "Andrew", "Daniel", "William",
        "Joseph", "Christopher", "Anthony", "Ryan", "Nicholas", "David", "Alexander", "Tyler",
        "James", "Emma", "Madison", "Olivia", "Hannah", "Abigail", "Isabella", "Ashley",
        "Samantha", "Elizabeth", "Alexis", "Sarah", "Grace", "Alyssa", "Sophia", "Lauren", "Jacob"
    };

    public List<Person> Staff { get; set; } = new List<Person>();

    public RestaurantBuilder AddStaff(int countCleaner, int countCook, int countManager)
    {
        AddCleaner(countCleaner);
        AddCook(countCook);
        AddManager(countManager);
        return this;
    }

    private void AddCleaner(int count)
    {
        var rand = new Random();

        for (int i = 0; i < count; i++)
        {
            Staff.Add(new Cleaner(names[rand.Next(0, names.Count)]));
        }
    }

    private void AddManager(int count)
    {
        var rand = new Random();

        for (int i = 0; i < count; i++)
        {
            Staff.Add(new Manager(names[rand.Next(0, names.Count)]));
        }
    }

    private void AddCook(int count)
    {
        var rand = new Random();

        for (int i = 0; i < count; i++)
        {
            Staff.Add(new Cook(names[rand.Next(0, names.Count)]));
        }
    }

    public Restaurant Build()
    {
        if (Staff.Count < 1) throw new Exception("You can't create a restaurant without staff");

        return new Restaurant("McDonald's", Staff);
    }
}