namespace Core.Settings;

public class ApiSettings : IConfiguration
{
    public string SectionName => "API";
    public string QaseAppUrl { get; set; }
    public string QaseAppToken { get; set; }
}
