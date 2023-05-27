namespace HomeWork6;

internal class Program
{
    private static void Main(string[] args)
    {
        var clinic = new Clinic("ZEMSCLINIC");

        var patients = new Patient[]
        {
            new Patient("Mr. Charley", IlnessType.Othes),
            new Patient("Mr. Thomas", IlnessType.Eyes),
            new Patient("Mr. George", IlnessType.Teeth),
            new Patient("Mr. Oscar", IlnessType.Unknown)
        };

        foreach (var patient in patients)
        {
            clinic.AddPatient(patient);
        }

        clinic.Treat();
    }
}