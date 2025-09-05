namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class DreamWorldDto
{
    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; } = string.Empty;
    
    [JsonPropertyName("front_female")]
    public string? FrontFemale { get; set; }
}
