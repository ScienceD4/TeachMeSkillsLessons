namespace HomeWork8;

public class Ration : Dictionary<DayOfWeek, List<Product>>
{
    public double GetSumCalories(DayOfWeek dayOfWeek)
    {
        var sumCalories = 0.0;

        if (TryGetValue(dayOfWeek, out var products))
        {
            foreach (var product in products)
            {
                sumCalories += product.FullСalories;
            }
        }

        return sumCalories;
    }

    public void PrintInfo()
    {
        foreach (var pair in this)
        {
            Console.WriteLine(new string('-', 10));
            Console.WriteLine(pair.Key.ToString());
            Console.WriteLine();

            foreach (var product in pair.Value)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine();
            Console.WriteLine($"Sum {GetSumCalories(pair.Key),39: 0.##} calories");
            Console.WriteLine(new string('-', 10));
            Console.WriteLine();
        }
    }
}