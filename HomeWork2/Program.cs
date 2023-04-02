namespace HomeWork2;

public class Program
{
    public static void Main()
    {
        Task2();
    }

    public static void Task1()
    {
        Console.Write("Enter operand1: ");
        var operand1 = Convert.ToDouble(Console.ReadLine()?.Replace(".",","));
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
                result = Math.Pow(operand1,operand2);
                break;
            default:
                Console.WriteLine("Operation sign not defined");
                return;
        }
        Console.WriteLine($"{operand1} {sing} {operand2} = {result}");
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
}