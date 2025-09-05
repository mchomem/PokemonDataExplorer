namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class TypeDto
{    
    [JsonPropertyName("slot")]
    public int Slot { get; set; }

    [JsonPropertyName("type")]
    public TypeDetailDto Type { get; set; } = new();
}
