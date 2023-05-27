namespace HomeWork11NUnit;

public class Calculator
{
    public double X { get; set; }
    public double Y { get; set; }

    public double Sum() => X + Y;

    public double Sub() => X - Y;

    public double Mult() => X * Y;

    public double Div() => X / Y;
}