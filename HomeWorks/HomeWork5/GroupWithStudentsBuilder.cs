namespace HomeWork5;

public class GroupWithStudentsBuilder
{
    private int CountGroups { get; set; }
    private int CountStudents { get; set; }

    public GroupWithStudentsBuilder AddCountGroups(int count)
    {
        CountGroups = count;
        return this;
    }

    public GroupWithStudentsBuilder AddCountStudents(int count)
    {
        CountStudents = count;
        return this;
    }

    public Group[] Build()
    {
        if (CountStudents < 1 || CountGroups < 1)
            throw new Exception("It is necessary to set the number of groups and students");

        var groups = new Group[CountGroups];

        for (int i = 0; i < CountGroups; i++)
        {
            var students = new Student[CountStudents];

            for (int j = 0; j < CountStudents; j++)
            {
                var id = i * CountStudents + j;
                var rand = new Random();
                var name = "Student" + (id + 1);
                var age = rand.Next(17, 24);

                var minMark = 1;
                var maxMark = 10;

                students[j] = new Student(id, name, age)
                {
                    BiologyMark = rand.Next(minMark, maxMark + 1),
                    MathMark = rand.Next(minMark, maxMark + 1),
                    PhysicalEducationMark = rand.Next(minMark, maxMark + 1)
                };

                //var money = Math.Round(rand.NextDouble() * 99 + 1, 2);
                //students[j].AddReward(money);
            }

            var groupName = "Group" + (i + 1);
            groups[i] = new Group(groupName, students);
        }

        return groups;
    }
}