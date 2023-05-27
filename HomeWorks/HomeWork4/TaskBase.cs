namespace HomeWork4;

/// <summary>
/// Родительский класс для всех Task.
/// Для обертки вывода на консоль.
/// </summary>
public abstract class TaskBase
{
    public void Run()
    {
        Console.WriteLine($"{new string('*', 5)} {this.GetType().Name} {new string('*', 5)}");

        DoWork();

        Console.WriteLine(new string('*', 17));
        Console.WriteLine();
    }

    protected abstract void DoWork();
}