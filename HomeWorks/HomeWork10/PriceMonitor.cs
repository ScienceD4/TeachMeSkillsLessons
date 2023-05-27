using HomeWork10.Interfaces;
using System.Collections.Generic;

namespace HomeWork10;

public class PriceMonitor : Publisher
{
    private readonly decimal minPrice = 1_000m;
    private readonly decimal maxPrice = 100_000m;
    private readonly decimal notifyPrice = 59_000m;
    private readonly List<Subscriber> subscribers = new();
    private decimal price;

    public Action<decimal> ShowPrice { get; private set; }

    public PriceMonitor(Action<decimal> showPrice)
    {
        ShowPrice = showPrice;
        price = maxPrice;
    }

    public void GeneratePrice()
    {
        var rand = new Random();

        price = Math.Round(
            minPrice + (decimal)rand.NextDouble() * (maxPrice - minPrice),
            2);

        ShowPrice?.Invoke(price);

        var data = new Data() { Price = price, IsLowPrice = false};

        if (price < notifyPrice)
        {
            data.IsLowPrice = true;
        }

        Notify(data);
    }

    public void Subscribe(Subscriber sub)
    {
        subscribers.Add(sub);
    }

    public void Unsubscribe(Subscriber sub)
    {
        subscribers.Remove(sub);
    }

    private void Notify(Data data)
    {
        subscribers.ForEach(s => s.Update(data));
    }
}
