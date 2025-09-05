namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class CryDto
{
    [JsonPropertyName("latest")]
    public string Latest { get; set; } = string.Empty;

    [JsonPropertyName("legacy")]
    public string Legacy { get; set; } = string.Empty;
}
