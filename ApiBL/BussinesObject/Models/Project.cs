using Newtonsoft.Json;

namespace ApiTests.BussinesObject.Models;

public class Project
{
    public string Title { get; set; }

    public string Code { get; set; }

    public Counts Counts { get; set; }
}

public class Counts
{
    public int Cases { get; set; }

    public int Suites { get; set; }

    public int Milestones { get; set; }

    public Runs Runs { get; set; }

    public Defects Defects { get; set; }
}

public class Defects
{
    public int Total { get; set; }

    public int Open { get; set; }
}

public class Runs
{
    public int Total { get; set; }

    public int Active { get; set; }
}

public class CreateProjectRequest
{
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Description { get; set; }

    [JsonProperty("access", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Access { get; set; }

    [JsonProperty("group", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Group { get; set; }
}