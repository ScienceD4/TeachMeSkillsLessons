using Newtonsoft.Json;

namespace ApiBL.BussinesObject.Models;

public class CaseBase
{
    [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public int? Id { get; set; }

    [JsonProperty("attachments", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public List<string>? Attachments { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string? Description { get; set; }

    [JsonProperty("preconditions", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string? Preconditions { get; set; }

    [JsonProperty("postconditions", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string? Postconditions { get; set; }

    [JsonProperty("severity", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public int? Severity { get; set; }

    [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public int? Priority { get; set; }

    [JsonProperty("automation", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public int? Automation { get; set; }

    [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public int? Status { get; set; }

    [JsonProperty("created_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public DateTime? CreatedAt { get; set; }

    [JsonProperty("updated_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public DateTime? UpdatedAt { get; set; }
}

public class CaseCreateModel : CaseBase
{

    [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public List<string>? Tags { get; set; }
}

public class Case : CaseBase
{

    [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public List<Tag>? Tags { get; set; }
}

public class CreateCaseBulkRequest
{
    [JsonProperty("cases")]
    public List<CaseCreateModel>? Cases { get; set; }
}

public class Tag
{
    [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public string Title { get; set; }

    [JsonProperty("internal_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
    public int InternalId { get; set; }
}
