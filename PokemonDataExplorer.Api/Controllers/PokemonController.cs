namespace PokemonDataExplorer.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PokemonController : ControllerBase
{
    private readonly IPokemonApi _pokemonApi;
    private readonly PokemonApiConfig _pokemonApiConfig;
    private readonly ILogger<PokemonController> _logger;

    public PokemonController(IPokemonApi pokemonApi, IOptionsMonitor<PokemonApiConfig> pokemonApiConfig, ILogger<PokemonController> logger)
    {
        _pokemonApi = pokemonApi;
        _pokemonApiConfig = pokemonApiConfig.CurrentValue; // Capture the current value of the configuration
        _logger = logger;
    }

    [HttpGet("{name}")]
    public async Task<IActionResult> GetPokemonAsync(string name)
    {
        var pokemonData = await _pokemonApi.GetPokemonAsync(name);

        _logger.LogInformation("Fetched data for Pokemon: {Name} from {BaseUrl}", name, _pokemonApiConfig.BaseUrl);

        return Ok(pokemonData);
    }

    [HttpGet]
    // https://pokeapi.co/api/v2/pokemon?offset=20&limit=20
    public async Task<IActionResult> GetAllPokemonsAsync([FromQuery] int? offset, [FromQuery] int? limit)
    {
        var pokemons = await _pokemonApi.GetAllPokemonsAsync(offset, limit);

        return Ok(pokemons);
    }
}
