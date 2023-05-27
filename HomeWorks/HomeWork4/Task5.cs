using System.Text;

namespace HomeWork4;

/// <summary>
/// 5. Введите с консоли строку, которая будет содержать буквы и цифры.
/// Удалите из исходной строки все цифры и выведите их на экран.
/// (Использовать метод Char.IsDigit(), его не разбирали на уроке, посмотрите, пожалуйста, документацию этого метода самостоятельно)
/// </summary>
public class Task5 : TaskBase
{
    protected override void DoWork()
    {
        Console.Write("Enter a string: ");
        var text = Console.ReadLine();
        Console.WriteLine();

        var newText = new StringBuilder();

        foreach (var ch in text)
        {
            if (!char.IsDigit(ch))
            {
                newText.Append(ch);
            }
        }

        Console.Write("String without numbers: ");
        Console.WriteLine(newText.ToString());
    }
}