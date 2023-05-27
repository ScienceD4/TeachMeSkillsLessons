namespace HomeWork3;

/// <summary>
/// 8 Создайте двумерный массив. Выведите на консоль диагонали массива.
/// </summary>
public static class Task8
{
    public static void Run()
    {
        Console.WriteLine($"{new string('*', 5)} {nameof(Task8)} {new string('*', 5)}");
        Console.WriteLine();

        var length = 4;
        var array = Common.Generate2DArrayInt32(length, length, 1, 10);

        Console.WriteLine("Array:");
        Common.Print2DArray(array);
        Console.WriteLine();

        PrintMainDiagonal(array);
        PrintSideDiagonal(array);

        Console.WriteLine(new string('*', 17));
        Console.WriteLine();
    }

    private static void PrintMainDiagonal(int[,] array)
    {
        var length = Math.Min(array.GetLength(0), array.GetLength(1));

        Console.WriteLine("Main diagonal:");
        for (int i = 0; i < length; i++)
        {
            Console.Write($"{array[i, i]} ");
        }
        Console.WriteLine();
    }

    private static void PrintSideDiagonal(int[,] array)
    {
        var length = Math.Min(array.GetLength(0), array.GetLength(1));

        Console.WriteLine("Side diagonal:");
        for (int i = length - 1, j = 0; i >= 0; i--, j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}