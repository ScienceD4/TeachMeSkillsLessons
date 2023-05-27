namespace HomeWork3;

/// <summary>
/// 1. Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
/// Пусть число задается с консоли.Если такого числа нет - выведите сообщения об этом.
/// В результате должен быть новый массив без указанного числа.
/// </summary>
public static class Task1
{
    public static void Run()
    {
        Console.WriteLine($"{new string('*', 5)} {nameof(Task1)} {new string('*', 5)}");

        var array = Common.GenerateArrayInt32(10, 0, 10);

        Console.WriteLine("Array:");
        Console.WriteLine(string.Join(' ', array));
        Console.WriteLine();

        Console.Write("Enter number (in range 0-9): ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        CheckNumberInArrayAndPrint(array, number);
        Console.WriteLine();
        CheckNumberInArrayAndPrintVersion2(array, number);
        Console.WriteLine();

        Console.WriteLine(new string('*', 17));
        Console.WriteLine();
    }

    private static void CheckNumberInArrayAndPrint(int[] array, int number)
    {
        Console.WriteLine("CheckNumberVersion1:");

        if (array.Contains(number))
        {
            Console.WriteLine($"Array contain number {number}");
            Console.WriteLine("Output without a number:");
            Console.WriteLine(string.Join(' ', array.Where(i => i != number)));
        }
        else Console.WriteLine($"Array dont contain number {number}");
    }

    private static void CheckNumberInArrayAndPrintVersion2(int[] array, int number)
    {
        Console.WriteLine("CheckNumberVersion2:");

        var isNumberContains = false;

        foreach (var num in array)
        {
            if (num == number) isNumberContains = true;
        }

        if (isNumberContains)
        {
            Console.WriteLine($"Array contain number {number}");
            Console.WriteLine("Output without a number:");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != number)
                {
                    Console.Write(array[i]);
                    if (i != array.Length - 1) Console.Write(" ");
                }
            }
        }
        else Console.WriteLine($"Array dont contain number {number}");
    }
}