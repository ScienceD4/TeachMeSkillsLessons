namespace HomeWork3;

/// <summary>
/// 0. Создайте массив целых чисел. Напишете программу, которая выводит
/// сообщение о том, входит ли заданное число в массив или нет.
/// Пусть число для поиска задается с консоли.
/// </summary>
public static class Task0
{
    public static void Run()
    {
        Console.WriteLine($"{new string('*', 5)} {nameof(Task0)} {new string('*', 5)}");

        var array = Common.GenerateArrayInt32(10, 0, 10);

        Console.WriteLine("Array:");
        Console.WriteLine(string.Join(' ', array));
        Console.WriteLine();

        Console.Write("Enter number (in range 0-9): ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        CheckNumberInArray(array, number);
        Console.WriteLine();
        CheckNumberInArrayVersion2(array, number);
        Console.WriteLine();

        Console.WriteLine(new string('*', 17));
        Console.WriteLine();
    }

    private static void CheckNumberInArray(int[] array, int number)
    {
        Console.WriteLine("CheckNumberVersion1:");

        if (array.Contains(number))
        {
            Console.WriteLine($"Array contain number {number}");
        }
        else Console.WriteLine($"Array dont contain number {number}");
    }

    private static void CheckNumberInArrayVersion2(int[] array, int number)
    {
        Console.WriteLine("CheckNumberVersion2:");

        var isNumberContains = false;

        foreach (var num in array)
        {
            if (num == number)
            {
                isNumberContains = true;
                break;
            }
        }

        if (isNumberContains)
        {
            Console.WriteLine($"Array contain number {number}");
        }
        else Console.WriteLine($"Array dont contain number {number}");
    }
}