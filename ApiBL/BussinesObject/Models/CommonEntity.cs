namespace ApiTests.BussinesObject.Models;

public class CommonEntity<T>
{
    public int Total { get; set; }
    public int Filtered { get; set; }
    public int Count { get; set; }
    public List<T> Entities { get; set; }
}