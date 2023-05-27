using System.Runtime;

namespace HomeWork10;

public class Linq
{
    /// <summary>
    /// Метод возвращает первое слово из последовательности слов, содержащее только одну букву.
    /// </summary>
    /// <param name="strings">Последовательность строк</param>
    /// <returns></returns>
    public static string? FirstWord(IEnumerable<string> strings)
    {
        return strings.FirstOrDefault(s => s.Length == 1);
    }

    /// <summary>
    /// Метод, возвращающий последнее слово, содержащее в себе подстроку
    /// </summary>
    /// <param name="strings">Последовательность строк</param>
    /// <param name="substring">подстрока</param>
    /// <returns></returns>
    public static string? LastWordContains(IEnumerable<string> strings, string substring)
    {
        return strings.LastOrDefault(s => s.Contains(substring));
    }

    /// <summary>
    /// метод для возврата последнего слова,
    /// соответствующего условию: длина слова не меньше min и не больше max.
    /// </summary>
    /// <param name="strings">Последовательность строк</param>
    /// <param name="minLen"></param>
    /// <param name="maxLen"></param>
    /// <returns></returns>
    public static string? LastWordWithParams(IEnumerable<string> strings, int minLen, int maxLen)
    {
        return strings.LastOrDefault(s => s.Length > minLen && s.Length < maxLen);
    }

    /// <summary>
    /// метод, который возвращает количество уникальных значений в последовательности
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="array"></param>
    /// <returns></returns>
    public static int CountUniqueElements<T>(IEnumerable<T> array)
    {
        return array.GroupBy(i => array.Count(j => j.Equals(i)))
                    .FirstOrDefault(g => g.Key == 1)
                    ?.Count() ?? 0;
    }

    /// <summary>
    /// метод, который принимает список и извлекает значения с "start" элемента (включительно)
    /// те значение которые содержат "number"
    /// </summary>
    /// <param name="ints"></param>
    /// <param name="start"></param>
    /// <param name="number"></param>
    /// <returns></returns>
    public static IEnumerable<int> GetNumbers(IEnumerable<int> ints, int start, int number)
    {
        return ints.Skip(start - 1).Where(i => i == number);
    }

    /// <summary>
    /// Метод возвращает длину самого короткого слова
    /// </summary>
    /// <param name="strings"></param>
    /// <returns></returns>
    public static int GetLenShortestWord(IEnumerable<string> strings)
    {
        return strings.MinBy(s => s.Length)?.Length ?? -1;
    }

    /// <summary>
    /// метод, который преобразует словарь в список и меняет местами каждый ключ и значение
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="dict"></param>
    /// <returns></returns>
    public static List<T> DictToList<T>(Dictionary<T, T> dict)
    {
        var list = new List<T>();

        foreach (var pair in dict)
        {
            list.Add(pair.Value);
            list.Add(pair.Key);
        }
        return list;
    }

    /// <summary>
    /// метод, который возвращает предоставленный список пользователей,
    /// упорядоченный по LastName в порядке убывания
    /// </summary>
    /// <param name="users"></param>
    /// <returns></returns>
    public static List<User> SortedUsers(IEnumerable<User> users)
    {
        return users.OrderBy(u => u.LastName).ToList();
    }
}

public class User
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }

    public User(string firstName, string middleName, string lastName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"<{FirstName}>" +
            $"{(string.IsNullOrWhiteSpace(MiddleName) ? " " : $" <{MiddleName}> " )}" +
            $"<{LastName}>";
    }
}
