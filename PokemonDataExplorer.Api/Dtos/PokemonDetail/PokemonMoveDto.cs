namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class PokemonMoveDto
{
    [JsonPropertyName("move")]
    public MoveDto Move { get; set; } = new();
    
    [JsonPropertyName("version_group_details")]
    public IEnumerable<VersionGroupDetailsDto> VersionGroupDetails { get; set; } = Enumerable.Empty<VersionGroupDetailsDto>();
}
