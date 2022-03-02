using Newtonsoft.Json;

namespace NotionCore.Shared.Responses._Globals;

public class Parent
{
    [JsonProperty("type")] public string Type { get; set; } = default!;

    [JsonProperty("database_id")] public string DatabaseId { get; set; } = default!;
}