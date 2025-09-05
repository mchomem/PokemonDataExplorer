namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class PastTypeTypeDto
{
    [JsonPropertyName("slot")]
    public int Slot { get; set; }
    
    [JsonPropertyName("type")]
    public PastTypeTypeTypeDto Type { get; set; } = new();
}
