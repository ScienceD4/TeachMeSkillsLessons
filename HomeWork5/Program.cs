namespace HomeWork5;

internal class Program
{
    private static void Main()
    {
        var gBuilder = new GroupWithSrudentsBuilder();

        var groups = gBuilder
            .AddCountGroups(3)
                .AddCountStudents(5)
                    .Build();

        var gPrinter = new GroupWithSrudentsPrinter(groups);

        Console.WriteLine($"We have {groups.Length} Groups\r\n");
        gPrinter.PrintAllGroups();

        var gOperation = new GroupWithSrudentsOperation(groups);

        GroupWithSrudentsOperation.AddReward(gOperation.StudentsWithMaxMathMarkOfGroup);
        GroupWithSrudentsOperation.AddReward(gOperation.StudentsWithMaxPhysicalEducationMarkOfGroup);
        GroupWithSrudentsOperation.AddReward(gOperation.StudentsWithMaxBiologyMarkOfGroup);

        GroupWithSrudentsPrinter.PrintStudentsWithMaxMark(gOperation);

        gPrinter.PrintAverageEveryMarks();

        gPrinter.PrintAverageAllMarks();

        var groupHighestAverage = gOperation.GroupHighestAverageMarks;

        GroupWithSrudentsOperation.AddReward(groupHighestAverage.Students);

        Console.WriteLine("Result:");
        gPrinter.PrintAllGroups();

        gPrinter.PrintStudentsWithHighestReward(gOperation);
    }
}