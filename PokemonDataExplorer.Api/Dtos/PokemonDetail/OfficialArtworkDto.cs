namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class OfficialArtworkDto
{
    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; } = string.Empty;
    
    [JsonPropertyName("front_shiny")]
    public string FrontShiny { get; set; } = string.Empty;
}
