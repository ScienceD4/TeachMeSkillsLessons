namespace HomeWork2;

public class Program
{
    public static void Main()
    {
        Task3();
    }

    public static void Task1()
    {
        Console.Write("Enter operand1: ");
        var operand1 = Convert.ToDouble(Console.ReadLine()?.Replace(".", ","));
        Console.Write("Enter operand2: ");
        var operand2 = Convert.ToDouble(Console.ReadLine()?.Replace(".", ","));
        Console.Write("Enter the sign of operation: ");
        var sing = Console.ReadLine();
        double result;

        switch (sing)
        {
            case "*":
                result = operand1 * operand2;
                break;
            case "+":
                result = operand1 + operand2;
                break;
            case "-":
                result = operand1 - operand2;
                break;
            case "/":
                if (operand2 == 0)
                {
                    Console.WriteLine($"{operand1} {sing} {operand2} = Infinity");
                    return;
                }
                result = operand1 / operand2;
                break;
            case "%":
                result = operand1 % operand2;
                break;
            case "^":
                result = Math.Pow(operand1, operand2);
                break;
            default:
                Console.WriteLine("Operation sign not defined");
                return;
        }
        Console.WriteLine($"{operand1} {sing} {operand2} = {result}");
    }

    public static void Task1Version2()
    {
        Console.Write("Enter operand1: ");
        var operand1 = Convert.ToDouble(Console.ReadLine()?.Replace(".", ","));
        Console.Write("Enter operand2: ");
        var operand2 = Convert.ToDouble(Console.ReadLine()?.Replace(".", ","));
        Console.Write("Enter the sign of operation: ");
        var sing = Console.ReadLine() ?? string.Empty;
        string result;

        var dictionaryOfoperations = new Dictionary<string, Func<double, double, string>>()
        {
            { "*", (a, b) => (a * b).ToString() },
            { "+", (a, b) => (a + b).ToString() },
            { "-", (a, b) => (a - b).ToString() },
            { "/", (a, b) => b == 0 ? "Infinity" : (a / b).ToString() },
            { "%", (a, b) => (a % b).ToString() },
            { "^", (a, b) => Math.Pow(a, b).ToString() },
        };

        if (dictionaryOfoperations.TryGetValue(sing, out var operation))
        {
            result = operation(operand1, operand2);
            Console.WriteLine($"{operand1} {sing} {operand2} = {result}");
        }
        else
        {
            Console.WriteLine("Operation sign not defined");
        }
    }

    public static void Task2()
    {
        Console.Write("Enter number: ");
        var number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
            Console.WriteLine("The number is not in any range. It is less than zero");
        else if (number < 15)
            Console.WriteLine("Range [0 - 14]");
        else if (number < 36)
            Console.WriteLine("Range [15 - 35]");
        else if (number < 51)
            Console.WriteLine("Range [36 - 50]");
        else if (number < 101)
            Console.WriteLine("Range [51 - 100]");
        else
            Console.WriteLine("The number is not in any range. It is over 100");
    }

    public static void Task3()
    {
        var dictionary = new Dictionary<string, string>()
        {
            { "солнечно", "sunny" },
            {"ясно", "clear"},
            { "облачно", "cloudy" },
            { "дождь", "rain" },
            { "снег", "snow" },
            { "ветер", "wind" },
            { "туман", "fog" },
            { "гроза", "thunderstorm" },
            { "жара", "heat" },
            { "холод", "cold" },
            { "влажность", "humidity" }
        };

        Console.Write("Enter a word in Russian: ");
        string russianWord = Console.ReadLine() ?? string.Empty;

        if (dictionary.TryGetValue(russianWord.ToLower(), out var englishWord))
        {
            Console.WriteLine($"Translation of \"{russianWord}\" in English: {englishWord}");
        }
        else
        {
            Console.WriteLine($"Word \"{russianWord}\" not found in the dictionary.");
        }
    }

    public static void Task4()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
            Console.WriteLine($"Number {number} is even.");
        else
            Console.WriteLine($"Number {number} is odd.");
    }
}