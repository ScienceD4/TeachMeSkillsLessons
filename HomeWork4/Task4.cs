namespace HomeWork4;

/// <summary>
/// 4. Дана строка: Good day.
/// Необходимо с помощью метода substring удалить слово "Good". После чего необходимо используя команду insert создать строку со значением: The best day!!!!!!!!!.
/// Заменить последний "!" на "?" и вывести результат на консоль.
/// </summary>
public class Task4 : TaskBase
{
    protected override void DoWork()
    {
        var text = "Good day";

        text = text.Substring(text.IndexOf(' ') + 1);
        text = text.Insert(0, "The best ");
        text = text.Insert(text.Length, "!!!!!!!!!");
        text = text.Remove(text.Length - 1) + "?";

        Console.WriteLine(text);
    }
}