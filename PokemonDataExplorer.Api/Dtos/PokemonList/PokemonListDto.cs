namespace PokemonDataExplorer.Api.Dtos.PokemonList;

public class PokemonListDto
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("next")]
    public string Next { get; set; } = string.Empty;

    [JsonPropertyName("previous")]
    public string Previous { get; set; } = string.Empty;

    [JsonPropertyName("results")]
    public IEnumerable<ResultDto> Results { get; set; } = Enumerable.Empty<ResultDto>();
}
