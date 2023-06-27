namespace ApiTests.Models;

public class GetUserRequest
{
    public User Data { get; set; }
    public Support Support { get; set; }
}

public class Support
{
    public string Url { get; set; }
    public string Text { get; set; }
}