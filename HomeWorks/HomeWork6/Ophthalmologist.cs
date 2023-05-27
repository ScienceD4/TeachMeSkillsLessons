namespace HomeWork6;

public class Ophthalmologist : Doctor
{
    public Ophthalmologist(string name) : base(name)
    {
        IlnessType = IlnessType.Eyes;
    }

    public override void Treat(Patient patient)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        base.Treat(patient);
        Console.ResetColor();
    }
}