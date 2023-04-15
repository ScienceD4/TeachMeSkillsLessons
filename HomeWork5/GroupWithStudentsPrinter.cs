namespace HomeWork5;

public class GroupWithSrudentsPrinter
{
    public Group[] Groups { get; set; }

    public GroupWithSrudentsPrinter(Group[] groups)
    {
        Groups = groups;
    }

    public void PrintAllGroups()
    {
        foreach (var group in Groups)
        {
            Console.WriteLine(group);
            Console.WriteLine("ID\tName\t\tMath\tPhysEd\tBiology\tReward");
            group.PrintAllStudents();
            Console.WriteLine();
        }
    }

    public static void PrintStudents(Student[] students, string message = "")
    {
        if (!string.IsNullOrWhiteSpace(message)) Console.WriteLine(message);

        foreach (var student in students)
        {
            Console.WriteLine(student.Group);
            Console.WriteLine("ID\tName\t\tMath\tPhysEd\tBiology\tReward");
            Console.WriteLine(student);
        }
    }

    public void PrintAverageEveryMarks()
    {
        foreach (var group in Groups)
        {
            var message = $"{group}\r\n" +
                $"Average mark Math: {group.AverageMathMark}\r\n" +
                $"Average mark PhysicalEducation: {group.AveragePhysicalEducationMark}\r\n" +
                $"Average mark Biology: {group.AverageBiologyMark}";

            Console.WriteLine(message);
            Console.WriteLine();
        }
    }

    public static void PrintStudentsWithMaxMark(GroupWithSrudentsOperation gOperation)
    {
        GroupWithSrudentsPrinter.PrintStudents(
            gOperation.StudentsWithMaxMathMarkOfGroup,
            "Students with Max mathMark of Group:");
        Console.WriteLine();

        GroupWithSrudentsPrinter.PrintStudents(
            gOperation.StudentsWithMaxPhysicalEducationMarkOfGroup,
            "Students with Max physicalEducationMark of Group:");
        Console.WriteLine();

        GroupWithSrudentsPrinter.PrintStudents(
            gOperation.StudentsWithMaxBiologyMarkOfGroup,
            "Students with Max MaxBiologyMark of Group:");
        Console.WriteLine();
    }

    public void PrintAverageAllMarks()
    {
        foreach (var group in Groups)
        {
            var message = $"{group}\r\n" +
                $"Average mark : {group.AverageAllMarks}";

            Console.WriteLine(message);
            Console.WriteLine();
        }
    }

    public void PrintStudentsWithHighestReward(GroupWithSrudentsOperation gOperation)
    {
        GroupWithSrudentsPrinter.PrintStudents(
            gOperation.StudentsWithHighestReward,
            "Student(s) with Highest Reward:"
            );
    }
}