namespace TeachMeSkillsLessons;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter your name: ");
        var user = Console.ReadLine();
        Console.WriteLine(new string('*', 10));
        Console.WriteLine($"Hello {user}");
        Console.WriteLine(new string('*', 10));
    }
}