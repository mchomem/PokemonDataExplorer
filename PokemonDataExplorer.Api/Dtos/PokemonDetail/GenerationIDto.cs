namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class GenerationIDto
{
    [JsonPropertyName("red-blue")]
    public RedBlueDto RedBlue { get; set; } = new();

    [JsonPropertyName("yellow")]
    public YellowDto Yellow { get; set; } = new();
}
