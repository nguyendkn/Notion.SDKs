using Newtonsoft.Json;

namespace NotionCore.Shared.Responses._Globals;

public class CreatedBy
{
    [JsonProperty("object")] public string Object { get; set; } = default!;

    [JsonProperty("id")] public string Id { get; set; } = default!;
}