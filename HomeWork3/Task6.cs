namespace HomeWork3;

/// <summary>
/// 6.Реализуйте алгоритм сортировки массива пузырьком.
/// </summary>
public static class Task6
{
    public static void Run()
    {
        Console.WriteLine($"{new string('*', 5)} {nameof(Task6)} {new string('*', 5)}");

        var array = Common.GenerateArrayInt32(15);

        Console.WriteLine("Array:");
        Console.WriteLine(string.Join(' ', array));
        Console.WriteLine();

        Console.WriteLine("Sorted Array:");
        Common.Sort(array);
        Console.WriteLine(string.Join(' ', array));
        Console.WriteLine();

        Console.WriteLine(new string('*', 17));
        Console.WriteLine();
    }
}