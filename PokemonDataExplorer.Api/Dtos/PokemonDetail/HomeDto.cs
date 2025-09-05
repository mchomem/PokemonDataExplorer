namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class HomeDto
{
    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; } = string.Empty;

    [JsonPropertyName("front_female")]
    public string FrontFemale { get; set; } = string.Empty;

    [JsonPropertyName("front_shiny")]
    public string FrontShiny { get; set; } = string.Empty;

    [JsonPropertyName("front_shiny_female")]
    public string FrontShinyFemale { get; set; } = string.Empty;
}
