namespace ApiTests.BussinesObject.Models;

public class CommonData<T>
{
    public bool Status { get; set; }
    public T Result { get; set; }
}