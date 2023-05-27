namespace HomeWork8;

public static class RationCreator
{
    private static readonly Product[] products;

    static RationCreator()
    {
        var rand = new Random();

        products = new Product[]
        {
            new("bacon", rand.Next(100,250)),
            new("beef", rand.Next(100,250)),
            new("chicken", rand.Next(100,250)),
            new("meat", rand.Next(100,250)),
            new("pork", rand.Next(100,250)),
            new("apple", rand.Next(20,100)),
            new("banana", rand.Next(20,100)),
            new("cherry", rand.Next(20,100)),
            new("peach", rand.Next(20,100)),
            new("orange", rand.Next(20,100)),
            new("milk",  rand.Next(40,60)),
            new("yogurt",  rand.Next(50,70)),
            new("cake",  rand.Next(100,200)),
            new("chocolate",  rand.Next(100,200)),
            new("honey",  rand.Next(100,200)),
            new("popcorn", rand.Next(100,200)),
            new("coffee",  rand.Next(1,10)),
            new("tea",  rand.Next(1,5)),
            new("unfiltered beer",  rand.Next(40,60)),
            new("filtered beer",  rand.Next(40,60)),
            new("dark beer",  rand.Next(40,60)),
            new("Witbier",  rand.Next(40,60)),
            new("Double IPA",  rand.Next(40,60)),
            new("Stout",  rand.Next(40,60)),
            new("Porter",  rand.Next(40,60)),
            new("Brown Ale",  rand.Next(40,60)),
            new("English Bitter",  rand.Next(40,60)),
            new("Kölsch",  rand.Next(40,60)),
            new("Pilsner",  rand.Next(40,60)),
            new("Lager",  rand.Next(40,60)),
            new("Schwarzbier",  rand.Next(40,60)),
        };
    }

    public static Ration Create()
    {
        var ration = new Ration();

        foreach (var day in Enum.GetValues<DayOfWeek>())
        {
            var prodList = new List<Product>();

            var rand = new Random();

            var prodCount = rand.Next(1, 10);

            for (int j = 0; j < prodCount; j++)
            {
                var product = products[rand.Next(0, products.Length)].Copy();
                product.Weight = rand.Next(100, 1001);

                prodList.Add(product);
            }

            ration.Add(day, prodList);
        }

        return ration;
    }
}