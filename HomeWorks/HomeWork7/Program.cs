namespace HomeWork7;

internal class Program
{
    private static void Main()
    {
        var restaurant = new RestaurantBuilder()
            .AddStaff(1, 1, 1)
                .Build();

        restaurant.PrintInfo();
        Console.WriteLine();

        restaurant.Run();
    }
}