namespace Core.Settings;

public class BrowserSettings : IConfiguration
{
    public string SectionName => "Browser";

    public bool HeadLess { get; set; }
    public int TimeOutSeconds { get; set; }
    public string Type { get; set; }
}