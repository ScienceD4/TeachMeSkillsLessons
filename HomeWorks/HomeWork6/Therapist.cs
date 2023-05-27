namespace HomeWork6;

public class Therapist : Doctor
{
    public Therapist(string name) : base(name)
    {
        IlnessType = IlnessType.Othes;
    }

    public override void Treat(Patient patient)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        base.Treat(patient);
        Console.ResetColor();
    }
}