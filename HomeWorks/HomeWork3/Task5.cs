namespace HomeWork3;

/// <summary>
/// 5. Создайте массив строк. Заполните его произвольными именами людей.
/// Отсортируйте массив.
/// Результат выведите на консоль.
/// </summary>
public static class Task5
{
    public static void Run()
    {
        Console.WriteLine($"{new string('*', 5)} {nameof(Task5)} {new string('*', 5)}");

        var random = new Random();
        var array = new string[]
        {
            "caa",
            "aba",
            "cca",
            "aaa",
            "aca",
        };

        Console.WriteLine("We have array:\n\r");
        for (int i = 0; i < array.Length; i++)
        {
            //array[i] = GenerateToken(random.Next(4,10));
            Console.WriteLine(array[i]);
        }
        Console.WriteLine();

        Common.Sort(array);

        Console.WriteLine("Sorted array:\n\r");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        Console.WriteLine(new string('*', 17));
        Console.WriteLine();
    }
}