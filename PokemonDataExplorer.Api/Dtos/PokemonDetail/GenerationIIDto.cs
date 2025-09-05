namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class GenerationIIDto
{
    [JsonPropertyName("crystal")]
    public CrystalDto Crystal { get; set; } = new();

    [JsonPropertyName("gold")]
    public GoldDto Gold { get; set; } = new();

    [JsonPropertyName("silver")]
    public SilverDto Silver { get; set; } = new();
}
