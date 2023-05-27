namespace HomeWork3;

/// <summary>
/// 2. Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
/// Для генерации случайного числа используйте метод Random().
/// Пусть будет возможность создавать массив произвольного размера.
/// Пусть размер массива вводится с консоли.
/// </summary>
public static class Task2
{
    public static void Run()
    {
        Console.WriteLine($"{new string('*', 5)} {nameof(Task2)} {new string('*', 5)}");

        Console.Write("Enter length of array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        var array = Common.GenerateArrayInt32(n);

        Console.WriteLine("Array:");
        Console.WriteLine(string.Join(' ', array));
        Console.WriteLine();

        Console.WriteLine($"Max element: {array.MaxElement()}");
        Console.WriteLine($"Min element: {array.MinElement()}");
        Console.WriteLine($"Avg: {array.Avg()}");

        Console.WriteLine(new string('*', 17));
        Console.WriteLine();
    }
}