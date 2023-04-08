namespace HomeWork4;

/// <summary>
/// 3. Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
/// Необходимо найти в данной строке "abc", записав всё что до этих символов в переменную firstPart, а также всё, что после них во вторую secondPart.
/// Результат вывести в консоль.
/// </summary>
public class Task3 : TaskBase
{
    protected override void DoWork()
    {
        var text = "teamwithsomeofexcersicesabcwanttomakeitbetter";

        Console.Write("We have text: ");
        Console.WriteLine(text);
        Console.WriteLine();

        var subString = "abc";
        var index = text.IndexOf(subString);

        var firstPart = text.Remove(index);
        var secondPart = text.Substring(index + subString.Length);

        Console.Write("firstPart: ");
        Console.WriteLine(firstPart);
        Console.WriteLine();

        Console.Write("secondPart: ");
        Console.WriteLine(secondPart);
        Console.WriteLine();
    }
}