namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class HeldVersionDetailsVersionDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
}
