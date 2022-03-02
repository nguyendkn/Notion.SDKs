using NotionCore.Shared.Constants;
using NotionCore.Shared.Responses;
using NotionCore.Shared.Responses._Globals;
using RestSharp;

namespace NotionCore;

public interface INotionClient
{
    Task<NotionResponse<Database>> QueryAsync<T>(string database);
}

public class NotionClient : INotionClient
{
    private readonly NotionOptions _options;

    public NotionClient(NotionOptions options)
    {
        _options = options;
    }

    public async Task<NotionResponse<Database>> QueryAsync<T>(string database)
    {
        var client = new RestClient();
        var request = new RestRequest(new Uri($"{NotionConstants.NotionAPI}/databases/{database}/query"), Method.Post);
        request.AddHeader("Authorization", $"Bearer {_options.Token}");
        request.AddHeader("Notion-Version", _options.Version ?? NotionConstants.NotionVersion);
        request.AddParameter("application/json", string.Empty, ParameterType.RequestBody);
        var response = await client.ExecuteAsync<NotionResponse<Database>>(request);
        return response.Data ?? default!;
    }
}