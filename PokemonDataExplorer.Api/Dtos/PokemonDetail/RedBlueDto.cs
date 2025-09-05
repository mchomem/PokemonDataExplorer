namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class RedBlueDto
{
    [JsonPropertyName("back_default")]
    public string BackDefault { get; set; } = string.Empty;

    [JsonPropertyName("back_gray")]
    public string BackGray { get; set; } = string.Empty;

    [JsonPropertyName("back_transparent")]
    public string BackTransparent { get; set; } = string.Empty;

    [JsonPropertyName("front_default")]
    public string FrontDefault { get; set; } = string.Empty;

    [JsonPropertyName("front_gray")]
    public string FrontGray { get; set; } = string.Empty;

    [JsonPropertyName("front_transparent")]
    public string FrontTransparent { get; set; } = string.Empty;
}
