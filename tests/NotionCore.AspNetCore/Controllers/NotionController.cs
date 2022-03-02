using Microsoft.AspNetCore.Mvc;
using NotionCore.AspNetCore.Models;

namespace NotionCore.AspNetCore.Controllers;

[ApiController]
[Route("api/notion/[action]")]
public class NotionController : ControllerBase
{
    private readonly INotionClient _notionClient;

    public NotionController(INotionClient notionClient)
    {
        _notionClient = notionClient;
    }

    [HttpGet]
    public async Task<IActionResult> Test()
    {
        var response = await _notionClient.QueryAsync<Category>("5590ce176ed44797bbeb4f4e4bc92e18");
        return Ok(response);
    }
}