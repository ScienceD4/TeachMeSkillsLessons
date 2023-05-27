namespace HomeWork6;

public enum IlnessType
{
    Eyes,
    Teeth,
    Othes,
    Unknown
}

public abstract class Doctor
{
    public string Name { get; private set; }
    public IlnessType IlnessType { get; protected set; }

    protected Doctor(string name)
    {
        Name = name;
    }

    public virtual void Treat(Patient patient)
    {
        Console.Write(GetType().Name + " ");
        Console.WriteLine($"{Name} cured the patient {patient.Name}");
    }
}