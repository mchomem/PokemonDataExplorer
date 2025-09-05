namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class HeldDto
{
    [JsonPropertyName("item")]
    public HeldItemDto Item { get; set; } = new();
    
    [JsonPropertyName("version_details")]
    public IEnumerable<HeldVersionDetailsDto> VersionDetails { get; set; } = Enumerable.Empty<HeldVersionDetailsDto>();
}
