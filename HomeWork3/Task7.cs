namespace HomeWork3;

/// <summary>
/// 7. Создайте двумерный массив целых чисел.
/// Выведите на консоль сумму всех элементов массива.
/// </summary>
public static class Task7
{
    public static void Run()
    {
        Console.WriteLine($"{new string('*', 5)} {nameof(Task7)} {new string('*', 5)}");

        var random = new Random();
        var array = Common.Generate2DArrayInt32(4,3);

        Console.WriteLine("Array:\n\r");
        Common.Print2DArray(array);
        Console.WriteLine();

        var sum = 0;
        foreach (var num in array)
        {
            sum += num;
        }
        Console.WriteLine($"The sum: {sum}");

        Console.WriteLine(new string('*', 17));
        Console.WriteLine();
    }
}