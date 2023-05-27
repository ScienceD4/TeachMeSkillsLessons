namespace HomeWork6;

public class Patient
{
    public string Name { get; set; }
    public IlnessType IlnessType { get; set; }

    public Patient(string name, IlnessType ilnessType)
    {
        Name = name;
        IlnessType = ilnessType;
    }
}