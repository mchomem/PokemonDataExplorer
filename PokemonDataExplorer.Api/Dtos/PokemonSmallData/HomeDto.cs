namespace PokemonDataExplorer.Api.Dtos.PokemonSmallData;

public class HomeDto
{
    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; } = string.Empty;
}
