namespace HomeWork3;

public static class Common
{
    public static int[] GenerateArrayInt32(int length, int minValue = 0, int maxValue = 100)
    {
        var random = new Random();
        var array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(minValue, maxValue);
        }

        return array;
    }

    public static int[,] Generate2DArrayInt32(int length0, int length1, int minValue = 0, int maxValue = 100)
    {
        var random = new Random();
        var array = new int[length0, length1];

        for (int i = 0; i < length0; i++)
        {
            for (int j = 0; j < length1; j++)
            {
                array[i, j] = random.Next(minValue, maxValue);
            }
        }

        return array;
    }

    public static void Print2DArray<T>(T[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("{\t");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine("}");
        }
    }

    public static void Sort<T>(T[] array) where T : IComparable<T>
    {
        var length = array.Length;
        for (int i = length - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    (array[j + 1], array[j]) = (array[j], array[j + 1]);

                    /*
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    */
                }
            }
        }
    }

    public static bool NumberIsEven(int number)
    {
        if (number % 2 == 0)
            return true;
        return false;
    }

    public static string GenerateToken(int length)
    {
        var bytes = new byte[length];
        var rnd = new Random();
        rnd.NextBytes(bytes);
        return Convert.ToBase64String(bytes).Replace("=", "").Replace("+", "").Replace("/", "");
    }
}

public static partial class ArrayExtensions
{
    public static int MaxElement(this int[] array)
    {
        var length = array.Length;
        if (length == 0) throw new ArgumentException("Cannot find maximum element of empty array");

        var max = array[0];
        for (int i = 0; i < length; i++)
        {
            if (array[i] > max) max = array[i];
        }

        return max;
    }

    public static int MinElement(this int[] array)
    {
        var length = array.Length;
        if (length == 0) throw new ArgumentException("Cannot find minimum element of empty array");

        var min = array[0];
        for (int i = 0; i < length; i++)
        {
            if (array[i] < min) min = array[i];
        }

        return min;
    }

    public static double Avg(this int[] array)
    {
        var length = array.Length;
        if (length == 0) throw new ArgumentException("Cannot find avg of empty array");

        var sum = 0.0;
        for (int i = 0; i < length; i++)
        {
            sum += array[i];
        }

        return sum / length;
    }

    public static int MaxElement(this int[,] array)
    {
        var length = array.Length;
        if (length == 0) throw new ArgumentException("Cannot find maximum element of empty array");

        var max = array[0, 0];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] > max) max = array[i, j];
            }
        }

        return max;
    }

    public static int MinElement(this int[,] array)
    {
        var length = array.Length;
        if (length == 0) throw new ArgumentException("Cannot find minimum element of empty array");

        var min = array[0, 0];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] > min) min = array[i, j];
            }
        }

        return min;
    }

    public static double Avg(this int[,] array)
    {
        var length = array.Length;
        if (length == 0) throw new ArgumentException("Cannot find avg of empty array");

        var sum = 0.0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
        }

        return sum / length;
    }
}