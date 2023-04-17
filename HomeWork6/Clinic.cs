namespace HomeWork6;

public class Clinic
{
    public string Title { get; private set; }
    public Patient[]? Patients { get; private set; }
    public Doctor[] Doctors { get; private set; }

    public Clinic(string title)
    {
        Title = title;

        Doctors = new Doctor[]
        {
            new Ophthalmologist("Dr. Alex"),
            new Dentist("Dr. Jack"),
            new Therapist("Dr. Harry")
        };
    }

    public void AddPatient(Patient patient)
    {
        if (Patients is null)
        {
            Patients = new Patient[] { patient };
            return;
        }

        if (Patients.Contains(patient)) return;

        var newPatients = new Patient[Patients.Length + 1];
        for (int i = 0; i < Patients.Length; i++)
        {
            newPatients[i] = Patients[i];
        }
        newPatients[Patients.Length] = patient;
        Patients = newPatients;
    }

    private bool RemovePatient(Patient patient)
    {
        if (Patients is null)
            return false;

        if (!Patients.Contains(patient)) return false;

        if (Patients.Length < 2)
        {
            Patients = null;
            return true;
        }

        var newPatients = new Patient[Patients.Length - 1];
        for (int i = 0, j = 0; i < Patients.Length; i++)
        {
            if (Patients[i] != patient)
            {
                newPatients[j] = Patients[i];
                j++;
            }
        }

        Patients = newPatients;
        return true;
    }

    public void Treat()
    {
        if (Patients is null || Patients.Length < 1)
        {
            Console.WriteLine($"{Title} has no patients");
            return;
        }

        Console.WriteLine($"{Title} starts treatment of patients");

        var count = Patients.Length;

        for (int i = 0; i < count; count--)
        {
            TreatPatient(Patients[i]);
        }
        Console.WriteLine("All patients are cured");
    }

    private void TreatPatient(Patient patient)
    {
        foreach (var doctor in Doctors)
        {
            if (doctor.IlnessType == patient.IlnessType)
            {
                doctor.Treat(patient);
                RemovePatient(patient);
                return;
            }
        }

        Console.WriteLine($"Patient {patient.Name} has an Unknown IlnessType");
        RemovePatient(patient);
    }
}