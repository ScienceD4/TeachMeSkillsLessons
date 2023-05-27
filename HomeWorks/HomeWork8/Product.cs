namespace HomeWork8;

public class Product
{
    public string Name { get; set; }
    public double Calories { get; set; }
    public double Weight { get; set; }
    public double FullСalories => Calories * Weight / 100;

    public Product(string name, double calories)
    {
        Name = name;
        Calories = calories;
    }

    public Product Copy()
    {
        var prod = new Product(Name, Calories)
        {
            Weight = Weight
        };

        return prod;
    }

    public override string ToString()
    {
        return $"{Name,-16} {Calories,4}/100g {Weight,5}g {FullСalories,9} calories";
    }
}