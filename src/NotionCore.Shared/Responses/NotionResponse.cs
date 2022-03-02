using Newtonsoft.Json;

namespace NotionCore.Shared.Responses;

public interface INotionParameters
{
    [JsonProperty("start_cursor")] string StartCursor { get; set; }

    [JsonProperty("page_size")] int? PageSize { get; set; }
}

public class NotionResponse<T>
{
    [JsonProperty("object")] public const string Object = "list";

    [JsonProperty("results")] public List<T>? Results { get; set; }

    [JsonProperty("has_more")] public bool HasMore { get; set; }

    [JsonProperty("next_cursor")] public string? NextCursor { get; set; }
}