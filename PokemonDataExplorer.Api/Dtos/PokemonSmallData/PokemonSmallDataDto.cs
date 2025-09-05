namespace PokemonDataExplorer.Api.Dtos.PokemonSmallData;

public class PokemonSmallDataDto
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("sprites")]
    public SpritesDto Sprites { get; set; } = new();

    public byte[] PokemonPicture { get; set; } = Array.Empty<byte>();
}
