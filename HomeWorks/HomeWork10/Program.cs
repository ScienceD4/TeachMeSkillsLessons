namespace HomeWork10;

internal class Program
{
    static void Main()
    {
        var monitor = new PriceMonitor(PrintPrice);
        var subscriber = new PriceSubscriber();
        monitor.Subscribe(subscriber);

        for (int i = 0; i < 10; i++)
        {
            monitor.GeneratePrice();
            Console.WriteLine();
        }
    }


    public static void PrintPrice(decimal price)
    {
        Console.WriteLine($"Price from delegate {price:### ###.## RUB}");
    }
}
