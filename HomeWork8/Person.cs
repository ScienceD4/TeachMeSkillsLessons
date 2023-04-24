namespace HomeWork8;

public class Person
{
    private Ration? ration;

    public string Name { get; set; }
    public double MaxNumberOfCalories { get; set; }
    public Ration? Ration { get => ration; set { CheckAndSetRation(value); } }

    public Person(string name, double maxNumberOfCalories)
    {
        Name = name;
        MaxNumberOfCalories = maxNumberOfCalories;
    }

    public Person(string name, double maxNumberOfCalories, Ration ration) : this(name, maxNumberOfCalories)
    {
        Ration = ration;
    }

    private void CheckAndSetRation(Ration? ration)
    {
        if (ration == null) return;

        foreach (var pair in ration)
        {
            while (ration.GetSumCalories(pair.Key) > MaxNumberOfCalories)
            {
                pair.Value.RemoveAt(pair.Value.Count - 1);
            }
        }

        this.ration = ration;
    }
}