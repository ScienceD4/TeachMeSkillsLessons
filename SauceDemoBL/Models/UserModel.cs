namespace Saucedemo.Models;

public class UserModel
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PostalCode { get; set; }
    public string? Login { get; set; }
    public string? Password { get; set; }

    public UserModel(string firstName, string lastName, string postalCode)
    {
        FirstName = firstName;
        LastName = lastName;
        PostalCode = postalCode;
    }

    public UserModel(string login, string password)
    {
        Login = login;
        Password = password;
    }
}