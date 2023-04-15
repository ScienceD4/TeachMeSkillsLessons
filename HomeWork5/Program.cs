namespace HomeWork5;

internal class Program
{
    private static void Main()
    {
        var gBuilder = new GroupWithStudentsBuilder();

        var groups = gBuilder
            .AddCountGroups(3)
                .AddCountStudents(5)
                    .Build();

        var gPrinter = new GroupWithStudentsPrinter(groups);

        Console.WriteLine($"We have {groups.Length} Groups\r\n");
        gPrinter.PrintAllGroups();

        var gOperation = new GroupWithStudentsOperation(groups);

        GroupWithStudentsOperation.AddReward(gOperation.StudentsWithMaxMathMarkOfGroup);
        GroupWithStudentsOperation.AddReward(gOperation.StudentsWithMaxPhysicalEducationMarkOfGroup);
        GroupWithStudentsOperation.AddReward(gOperation.StudentsWithMaxBiologyMarkOfGroup);

        GroupWithStudentsPrinter.PrintStudentsWithMaxMark(gOperation);

        gPrinter.PrintAverageEveryMarks();

        gPrinter.PrintAverageAllMarks();

        var groupHighestAverage = gOperation.GroupHighestAverageMarks;

        GroupWithStudentsOperation.AddReward(groupHighestAverage.Students);

        Console.WriteLine("Result:");
        gPrinter.PrintAllGroups();

        gPrinter.PrintStudentsWithHighestReward(gOperation);
    }
}