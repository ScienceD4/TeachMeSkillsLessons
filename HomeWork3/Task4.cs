namespace HomeWork3;

/// <summary>
/// 4. Создайте массив и заполните массив.
/// Выведите массив на экран в строку.
/// Замените каждый элемент с нечётным индексом на ноль.
/// Снова выведете массив на экран на отдельной строке.
/// </summary>
public static class Task4
{
    public static void Run()
    {
        Console.WriteLine($"{new string('*', 5)} {nameof(Task4)} {new string('*', 5)}");

        var array = Common.GenerateArrayInt32(10);

        Console.WriteLine("Array:");
        Console.WriteLine(string.Join(' ', array));
        Console.WriteLine();

        // TODO

        Console.WriteLine(new string('*', 17));
        Console.WriteLine();
    }
}