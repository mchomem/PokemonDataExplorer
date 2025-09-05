namespace PokemonDataExplorer.Api.Dtos.PokemonSmallData;

public class SpritesDto
{
    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; } = string.Empty;

    [JsonPropertyName("other")]
    public OtherDto Other { get; set; } = new();
}
