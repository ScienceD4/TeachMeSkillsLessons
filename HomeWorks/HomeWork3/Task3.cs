namespace HomeWork3;

/// <summary>
/// 3. Создайте 2 массива из 5 чисел. Выведите массивы на консоль в двух отдельных строках.
/// Посчитайте среднее арифметическое элементов каждого массива и сообщите,
/// для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).
/// </summary>
public static class Task3
{
    public static void Run()
    {
        Console.WriteLine($"{new string('*', 5)} {nameof(Task3)} {new string('*', 5)}");

        var array1 = Common.GenerateArrayInt32(5);
        var array2 = Common.GenerateArrayInt32(5);

        Console.WriteLine("Array1:");
        Console.WriteLine(string.Join(' ', array1));

        var array1Avg = array1.Avg();
        Console.WriteLine($"Avg: {array1Avg}");
        Console.WriteLine();

        Console.WriteLine("Array2:");
        Console.WriteLine(string.Join(' ', array2));

        var array2Avg = array2.Avg();
        Console.WriteLine($"Avg: {array2Avg}");
        Console.WriteLine();

        if (array1Avg > array2Avg)
        {
            Console.WriteLine("The average value of the Array1 is greater");
        }
        else if (array1Avg == array2Avg)
        {
            Console.WriteLine("Average values are equals");
        }
        else
        {
            Console.WriteLine("The average value of the Array2 is greater");
        }

        Console.WriteLine(new string('*', 17));
        Console.WriteLine();
    }
}