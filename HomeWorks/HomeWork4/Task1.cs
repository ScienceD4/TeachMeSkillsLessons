namespace HomeWork4;

/// <summary>
/// 1. Задать строку содержащую внутри цифры и несколько повторений слова test.
/// Заменить в строке все вхождения 'test' на 'testing'.
/// </summary>
public class Task1 : TaskBase
{
    protected override void DoWork()
    {
        var text = "test   4958test37598379 kjhtestkjhs djfhskr98 9875 29857  test test";

        Console.WriteLine("We have text:");
        Console.WriteLine(text);
        Console.WriteLine();

        var newText = text.Replace("test", "testing");

        Console.WriteLine("New text:");
        Console.WriteLine(newText);
    }
}