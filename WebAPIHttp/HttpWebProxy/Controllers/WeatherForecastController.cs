using HttpWebProxy.Services;
using Microsoft.AspNetCore.Mvc;

namespace HttpWebProxy.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly GitHubService _gitHubService;
    private readonly HttpClient _client;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, GitHubService gitHubService, HttpClient client)
    {
        _logger = logger;
        _gitHubService = gitHubService;
        _client = client;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IActionResult> Get()
    {
        var typeClient = _client.GetType();
        var gitHubClient = _gitHubService.GetType();

        var equals = typeClient.Equals(gitHubClient);

        var branchs = await _gitHubService.GetAspNetCoreDocsBranchesAsync();
        return Ok(branchs);
    }
}