namespace PokemonDataExplorer.Api.Dtos.PokemonSmallData;

public class OtherDto
{
    [JsonPropertyName("home")]
    public HomeDto Home { get; set; } = new();
}
