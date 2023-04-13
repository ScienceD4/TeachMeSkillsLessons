namespace HomeWork5;

public class Student
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public int Age { get; private set; }
    public Group Group { get; set; }
    public int MathMark { get; set; }
    public int PhysicalEducationMark { get; set; }
    public int BiologyMark { get; set; }
    public decimal Reward { get; private set; }

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public string AddReward(double money)
    {
        if (money < 0) return "Don't take my money!";
        if (money < 1) return "I don't need your pennies!";
        Reward += (decimal)money;
        return "Thank you!";
    }

    public override string ToString()
    {
        return $"({Id})\t{Name}\t{MathMark}\t{PhysicalEducationMark}\t{BiologyMark}\t{Reward}";
    }
}