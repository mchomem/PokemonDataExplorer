namespace PokemonDataExplorer.Api.Dtos.PokemonList;

public class ResultDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
}
