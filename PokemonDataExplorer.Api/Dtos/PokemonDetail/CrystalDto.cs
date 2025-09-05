namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class CrystalDto
{
    [JsonPropertyName("back_default")]
    public string BackDefault { get; set; } = string.Empty;

    [JsonPropertyName("back_shiny")]
    public string BackShiny { get; set; } = string.Empty;

    [JsonPropertyName("back_shiny_transparent")]
    public string BackShinyTransparent { get; set; } = string.Empty;

    [JsonPropertyName("back_transparent")]
    public string BackTransparent { get; set; } = string.Empty;

    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; } = string.Empty;

    [JsonPropertyName("front_shiny")]
    public string FrontShiny { get; set; } = string.Empty;

    [JsonPropertyName("front_shiny_transparent")]
    public string FrontShinyTransparent { get; set; } = string.Empty;

	[JsonPropertyName("front_transparent")]
	public string FrontTransparent { get; set; } = string.Empty;
}
