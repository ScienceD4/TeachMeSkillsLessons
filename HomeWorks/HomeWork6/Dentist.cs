namespace HomeWork6;

public class Dentist : Doctor
{
    public Dentist(string name) : base(name)
    {
        IlnessType = IlnessType.Teeth;
    }

    public override void Treat(Patient patient)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        base.Treat(patient);
        Console.ResetColor();
    }
}