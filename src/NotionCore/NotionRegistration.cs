using Microsoft.Extensions.DependencyInjection;

namespace NotionCore;

public static class NotionRegistration
{
    public static void NotionClient(this IServiceCollection services, NotionOptions notionOptions)
    {
        var notionClient = new NotionClient(notionOptions);
        services.AddSingleton<INotionClient>(notionClient);
    }
}