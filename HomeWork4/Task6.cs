namespace HomeWork4;

/// <summary>
/// 6. Задайте 2 предложения из консоли.
/// Для каждого слова первого предложения определите количество его вхождений во второе предложение.
/// </summary>
public class Task6 : TaskBase
{
    protected override void DoWork()
    {
        Console.Write("Enter a stringOne: ");
        var strOne = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Enter a stringTwo: ");
        var strTwo = Console.ReadLine();
        Console.WriteLine();

        var array = strOne.Split();

        var count = 0;
        foreach (var word in array)
        {
            if (strTwo.Contains(word, StringComparison.OrdinalIgnoreCase)) count++;
        }

        Console.WriteLine($"The strTwo contains {count} words from the strOne");
    }
}