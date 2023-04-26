using HomeWork9.Exceptions;

namespace HomeWork9;

public class Person
{
    private decimal salary;
    private int age;

    public string Name { get; set; }

    public int Age
    {
        get => age;
        set
        {
            if (value < 18)
                throw new AgeException($"Age less than 18: {value}");
            age = value;
        }
    }

    public decimal Salary
    {
        get => salary;
        set
        {
            if (value < 100)
                throw new SalaryException($"Salary less than 100: {value}");
            salary = value;
        }
    }

    public Person(string name, int age, decimal salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"person: {Name}, Age: {Age}, Salary: {Salary}";
    }
}