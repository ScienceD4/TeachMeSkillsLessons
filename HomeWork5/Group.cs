namespace HomeWork5;

public class Group
{
    public string Name { get; set; }
    public Student[] Students { get; set; }

    public double AverageMathMark => GetAverageMathMark();
    public double AveragePhysicalEducationMark => GetAveragePhysicalEducationMark();
    public double AverageBiologyMark => GetAverageBiologyMark();
    public double AverageAllMarks => GetAverageAllMarks();

    public Student StudentWithMaxMathMark => GetStudentWithMaxMathMark();
    public Student StudentWithMaxPhysicalEducationMark => GetStudentWithMaxPhysicalEducationMark();
    public Student StudentWithMaxBiologyMark => GetStudentWithMaxBiologyMark();

    private void CheckOrAddSelf(Student[] students)
    {
        foreach (var student in students)
        {
            if (student.Group is null) student.Group = this;
            else if (!student.Group.Equals(this)) student.Group = this;
        }
    }

    public Group(string name) => Name = name;

    public Group(string name, Student[] students)
    {
        Name = name;
        Students = students;
        CheckOrAddSelf(Students);
    }

    public void PrintAllStudents()
    {
        foreach (var student in Students)
        {
            Console.WriteLine(student);
        }
    }

    private double GetAverageMathMark()
    {
        var sum = 0.0;
        foreach (var student in Students)
        {
            sum += student.MathMark;
        }

        return sum / Students.Length;
    }

    private double GetAveragePhysicalEducationMark()
    {
        var sum = 0.0;
        foreach (var student in Students)
        {
            sum += student.PhysicalEducationMark;
        }

        return sum / Students.Length;
    }

    private double GetAverageBiologyMark()
    {
        var sum = 0.0;
        foreach (var student in Students)
        {
            sum += student.BiologyMark;
        }

        return sum / Students.Length;
    }

    private Student GetStudentWithMaxMathMark()
    {
        var students = Students;
        var student = students[0];
        var maxMark = student.MathMark;

        for (int i = 1; i < students.Length; i++)
        {
            if (students[i].MathMark > maxMark)
            {
                maxMark = students[i].MathMark;
                student = students[i];
            }
        }

        return student;
    }

    private Student GetStudentWithMaxPhysicalEducationMark()
    {
        var students = Students;
        var student = students[0];
        var maxMark = student.PhysicalEducationMark;

        for (int i = 1; i < students.Length; i++)
        {
            if (students[i].PhysicalEducationMark > maxMark)
            {
                maxMark = students[i].PhysicalEducationMark;
                student = students[i];
            }
        }

        return student;
    }

    private Student GetStudentWithMaxBiologyMark()
    {
        var students = Students;
        var student = students[0];
        var maxMark = student.BiologyMark;

        for (int i = 1; i < students.Length; i++)
        {
            if (students[i].BiologyMark > maxMark)
            {
                maxMark = students[i].BiologyMark;
                student = students[i];
            }
        }

        return student;
    }

    private double GetAverageAllMarks()
    {
        return (AverageBiologyMark + AverageMathMark + AveragePhysicalEducationMark) / 3;
    }

    public override string ToString()
    {
        return Name;
    }
}