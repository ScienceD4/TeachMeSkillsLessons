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
        Console.WriteLine($"Max element: {array.MaxElement()}");
        Console.WriteLine($"Min element: {array.MinElement()}");
        Console.WriteLine($"Avg: {array.Avg()}");

        Console.WriteLine(new string('*', 17));
        Console.WriteLine();
    }
}