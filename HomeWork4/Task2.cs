namespace HomeWork4;

/// <summary>
/// 2. Создайте переменные, которые будут хранить следующие слова: (Welcome, to, the, TMS, lessons).
/// Выполните конкатенацию слов и выведите на экран следующую фразу:
/// Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
/// </summary>
public class Task2 : TaskBase
{
    protected override void DoWork()
    {
        var welcome = "Welcome";
        var to = "to";
        var the = "the";
        var tms = "TMS";
        var lessons = "lessons";
        var q = "\"";
        var s = " ";

        var textResult = q + welcome + q + s + q + to + q + s + q + the + q + s + q + tms + q + s + q + lessons + q;

        Console.WriteLine(textResult);
    }
}