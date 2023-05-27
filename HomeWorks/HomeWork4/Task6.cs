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
        var strOne = Console.ReadLine() ?? string.Empty;
        Console.WriteLine();
        Console.Write("Enter a stringTwo: ");
        var strTwo = Console.ReadLine() ?? string.Empty;
        Console.WriteLine();

        var wordsOne = strOne.Split();
        var wordsTwo = strTwo.Split();

        var occurrences = new int[wordsOne.Length];

        for (int i = 0; i < wordsOne.Length; i++)
        {
            foreach (var word in wordsTwo)
            {
                if (word.Equals(wordsOne[i], StringComparison.OrdinalIgnoreCase))
                {
                    occurrences[i]++;
                }
            }
        }

        for (int i = 0; i < wordsOne.Length; i++)
        {
            Console.WriteLine($"The word \"{wordsOne[i]}\" has {occurrences[i]} occurrences in a sentence stringTwo");
        }
    }
}