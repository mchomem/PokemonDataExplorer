namespace PokemonDataExplorer.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PokemonController : ControllerBase
{
    private readonly IPokemonApi _pokemonApi;
    private readonly PokemonApiConfig _pokemonApiConfig;
    private readonly ILogger<PokemonController> _logger;
    private readonly HttpClient _httpClient;

    public PokemonController(IPokemonApi pokemonApi, IOptionsMonitor<PokemonApiConfig> pokemonApiConfig, ILogger<PokemonController> logger, HttpClient httpClient)
    {
        _pokemonApi = pokemonApi;
        _pokemonApiConfig = pokemonApiConfig.CurrentValue; // Capture the current value of the configuration
        _logger = logger;
        _httpClient = httpClient;
    }

    [HttpGet("{name}")]
    public async Task<IActionResult> GetPokemonAsync([FromRoute] string name)
    {
        var pokemonData = await _pokemonApi.GetPokemonAsync(name);

        _logger.LogInformation("Fetched data for Pokemon: {Name} from {BaseUrl}", name, _pokemonApiConfig.BaseUrl);

        return Ok(pokemonData);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllPokemonsAsync([FromQuery] int? offset, [FromQuery] int? limit)
    {
        var pokemons = await _pokemonApi.GetAllPokemonsAsync(offset, limit);

        return Ok(pokemons);
    }

    [HttpGet("pdf/{name}")]
    public async Task<IActionResult> GetPokemonSmallDataToPDF([FromRoute] string name)
    {
        var pokemonDetails = await _pokemonApi.GetPokemonAsync(name);

        var pokemonSmallData = new PokemonSmallDataDto()
        {
            Id = pokemonDetails.Id,
            Name = pokemonDetails.Name,
            Sprites = new SpritesDto
            {
                FrontDefault = pokemonDetails.Sprites.FrontDefault,
                Other = new OtherDto()
                {
                    Home = new HomeDto()
                    {
                        FrontDefault = pokemonDetails.Sprites.Other.Home.FrontDefault
                    }
                }
            },
        };

        if (string.IsNullOrEmpty(pokemonDetails.Sprites.Other.Home.FrontDefault))
            pokemonSmallData.PokemonPicture = await DownloadImageInMemory(pokemonDetails.Sprites.FrontDefault);
        else
            pokemonSmallData.PokemonPicture = await DownloadImageInMemory(pokemonDetails.Sprites.Other.Home.FrontDefault);

        var pdfDocument = new PokemonReport(pokemonSmallData);
        var pdfBytes = pdfDocument.GeneratePdf();

        return File(pdfBytes, "application/pdf", $"{name}_report.pdf");
    }

    private async Task<byte[]> DownloadImageInMemory(string url)
    {
        var imageByte = await _httpClient.GetByteArrayAsync(url);
        return imageByte;
    }
}
