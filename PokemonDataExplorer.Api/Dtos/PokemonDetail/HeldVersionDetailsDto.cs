namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class HeldVersionDetailsDto
{
    [JsonPropertyName("rarity")]
    public int Rarity { get; set; }
    
    [JsonPropertyName("version")]
    public HeldVersionDetailsVersionDto Version { get; set; } = new();
}
