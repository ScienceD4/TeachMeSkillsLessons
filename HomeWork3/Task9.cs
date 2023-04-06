namespace HomeWork3;

/// <summary>
/// 9. Создайте массив из n случайных целых чисел и выведите его на экран.
/// Размер массива пусть задается с консоли и размер массива может быть больше 5 и меньше или равно 10.
/// Если n не удовлетворяет условию - выведите сообщение об этом.
/// Если пользователь ввёл не подходящее число, то программа должна просить пользователя повторить ввод.
/// Создайте второй массив только из чётных элементов первого массива, если они там есть, и вывести его на экран.
/// </summary>
public static class Task9
{
    public static void Run()
    {
        Console.WriteLine($"{new string('*', 5)} {nameof(Task9)} {new string('*', 5)}");

        int length;
        do
        {
            Console.Write("Enter length of array: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
        while (!CheckNumber(length));

        var array = Common.GenerateArrayInt32(length);

        Console.WriteLine("Array:");
        Console.WriteLine(string.Join(' ', array));
        Console.WriteLine();

        var newArray = new int[CountOfEvenNumbers(array)];

        var j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Common.NumberIsEven(array[i]))
            {
                newArray[j] = array[i];
                j++;
            }
        }

        Console.WriteLine("New Array (Only Even):");
        Console.WriteLine(string.Join(' ', newArray));
        Console.WriteLine();

        Console.WriteLine(new string('*', 17));
        Console.WriteLine();
    }

    private static bool CheckNumber(int number)
    {
        if (number <= 5 || number > 10)
        {
            Console.WriteLine("number can be greater than 5 and less than or equal to 10");
            return false;
        }
        return true;
    }

    private static int CountOfEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (var num in array)
        {
            if (Common.NumberIsEven(num)) count++;
        }
        return count;
    }
}