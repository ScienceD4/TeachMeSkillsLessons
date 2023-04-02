namespace HomeWork2;

public class Program
{
    public static void Main()
    {
        Task1();
    }

    public static void Task1()
    {
        Console.Write("Enter operand1: ");
        var operand1 = Convert.ToDouble(Console.ReadLine()?.Replace(",","."));
        Console.Write("Enter operand2: ");
        var operand2 = Convert.ToDouble(Console.ReadLine()?.Replace(",", "."));
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
}