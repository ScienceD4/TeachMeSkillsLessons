namespace Core.Settings.Files;

public class SalesForceSettings : IConfiguration
{
    public string SectionName => "SalesForce";

    public string Login { get; set; }
    public string Password { get; set; }
    public string Url { get; set; }
}