namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class OtherDto
{
    [JsonPropertyName("dream_world")]
    public DreamWorldDto DreamWorld { get; set; } = new();

    [JsonPropertyName("home")]
    public HomeDto Home { get; set; } = new();

    [JsonPropertyName("official-artwork")]
    public OfficialArtworkDto officialArtworkDto { get; set; } = new();
    
    [JsonPropertyName("showdown")]
    public ShowdownDto Showdown { get; set; } = new();
}
