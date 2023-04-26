using HomeWork9.Exceptions;

namespace HomeWork9;

internal class Program
{
    private static void Main()
    {
        try
        {
            var personList = new List<Person>()
            {
                new("Ap1", 21, 103),
                new("Bp2", 28, 1023),
                new("Ap3", 34, 2098),
                new("Cp4", 44, 980),
                new("Dp5", 55, 5000),
            };

            Console.WriteLine("All persons");
            PrintList(personList);
            Console.WriteLine();

            Console.WriteLine("name starts with A");

            PrintList(
                personList
                    .Where(p => p.Name.StartsWith('A'))
                    .ToList());
            Console.WriteLine();

            Console.WriteLine("salary over 1000 and age less 30");
            PrintList(
                personList
                    .Where(p => p.Salary > 1000
                            && p.Age < 30)
                    .ToList());
            Console.WriteLine();

            Console.WriteLine("first person over 50 age");
            Console.WriteLine(personList.FirstOrDefault(p => p.Age > 50)?.ToString() ?? "null");
            Console.WriteLine();

            Console.WriteLine("Random Error");
            if (DateTime.Now.Millisecond % 2 == 0)
            {
                var person = new Person("Jon", 20, 50);
            }
            else
            {
                var person = new Person("Jon", 10, 200);
            }
        }
        catch (AgeException ex)
        {
            LogException(ex);

        }
        catch (SalaryException ex)
        {
            LogException(ex);
        }
    }

    static void PrintList<T>(List<T> list)
    {
        if (list?.Any() ?? false)
        {
            list.ForEach(p => Console.WriteLine(p));
        }
        else
        {
            Console.WriteLine("null");
        }
    }

    private static void LogException(Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.StackTrace);

        if (ex.InnerException is not null)
        {
            LogException(ex.InnerException);
        }
    }
}