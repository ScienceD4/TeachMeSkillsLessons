namespace HomeWork5;

public class GroupWithStudentsOperation
{
    public Group[] Groups { get; set; }
    private Student[] studentsWithMaxBiologyMarkOfGroup;
    private Student[] studentsWithMaxMathMarkOfGroup;
    private Student[] studentsWithMaxPhysicalEducationMarkOfGroup;

    public GroupWithStudentsOperation(Group[] groups)
    {
        Groups = groups;
    }

    public Student[] StudentsWithMaxMathMarkOfGroup
    {
        get
        {
            if (studentsWithMaxMathMarkOfGroup is null)
            {
                studentsWithMaxMathMarkOfGroup = GetStudentsWithMaxMathMarkOfGroup();
            }
            return studentsWithMaxMathMarkOfGroup;
        }
    }

    public Student[] StudentsWithMaxPhysicalEducationMarkOfGroup
    {
        get
        {
            if (studentsWithMaxPhysicalEducationMarkOfGroup is null)
            {
                studentsWithMaxPhysicalEducationMarkOfGroup = GetStudentsWithMaxPhysicalEducationMarkOfGroup();
            }
            return studentsWithMaxPhysicalEducationMarkOfGroup;
        }
    }

    public Student[] StudentsWithMaxBiologyMarkOfGroup
    {
        get
        {
            if (studentsWithMaxBiologyMarkOfGroup is null)
            {
                studentsWithMaxBiologyMarkOfGroup = GetStudentsWithMaxBiologyMarkOfGroup();
            }
            return studentsWithMaxBiologyMarkOfGroup;
        }
    }

    public Group GroupHighestAverageMarks => GetGroupHighestAverageMarks();

    public Student[] StudentsWithHighestReward => GetStudentsWithHighestReward();

    private Student[] GetStudentsWithMaxMathMarkOfGroup()
    {
        var students = new Student[Groups.Length];

        for (int i = 0; i < Groups.Length; i++)
        {
            students[i] = Groups[i].StudentWithMaxMathMark;
        }

        return students;
    }

    public Student[] GetStudentsWithMaxPhysicalEducationMarkOfGroup()
    {
        var students = new Student[Groups.Length];

        for (int i = 0; i < Groups.Length; i++)
        {
            students[i] = Groups[i].StudentWithMaxPhysicalEducationMark;
        }

        return students;
    }

    public Student[] GetStudentsWithMaxBiologyMarkOfGroup()
    {
        var students = new Student[Groups.Length];

        for (int i = 0; i < Groups.Length; i++)
        {
            students[i] = Groups[i].StudentWithMaxBiologyMark;
        }

        return students;
    }

    public static void AddReward(Student[] students)
    {
        var rand = new Random();

        foreach (var student in students)
        {
            var money = Math.Round(rand.NextDouble() * 99 + 1, 2);
            student.AddReward(money);
        }
    }

    private Group GetGroupHighestAverageMarks()
    {
        var group = Groups[0];
        var maxAvg = group.AverageAllMarks;

        for (int i = 1; i < Groups.Length; i++)
        {
            if (Groups[i].AverageAllMarks > maxAvg)
            {
                maxAvg = Groups[i].AverageAllMarks;
                group = Groups[i];
            }
        }

        return group;
    }

    private Student[] GetStudentsWithHighestReward()
    {
        var countStudents = 0;
        var maxCountStudents = 0;
        var maxReward = Groups[0].Students[0].Reward;

        foreach (var group in Groups)
        {
            foreach (var student in group.Students)
            {
                if (student.Reward > maxReward)
                    maxReward = student.Reward;

                maxCountStudents++;
            }
        }

        var studentsTemp = new Student[maxCountStudents];

        foreach (var group in Groups)
        {
            foreach (var student in group.Students)
            {
                if (student.Reward == maxReward)
                {
                    studentsTemp[countStudents] = student;
                    countStudents++;
                }
            }
        }

        var students = new Student[countStudents];

        for (int i = 0; i < countStudents; i++)
        {
            students[i] = studentsTemp[i];
        }

        return students;
    }
}