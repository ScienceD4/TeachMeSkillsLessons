namespace HomeWork7.Personal;

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return GetType().Name + " " + Name;
    }
}