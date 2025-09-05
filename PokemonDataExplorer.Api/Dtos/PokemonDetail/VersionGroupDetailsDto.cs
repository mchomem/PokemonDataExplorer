namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class VersionGroupDetailsDto
{
    [JsonPropertyName("level_learned_at")]
    public int LevelLearnedAt { get; set; }

    [JsonPropertyName("move_learn_method")]
    public MoveLearnMethodDto MoveLearnMethod { get; set; } = new();
    
    [JsonPropertyName("order")]
    public int? Order { get; set; }
    
    [JsonPropertyName("version_group")]
    public VersionGroupDetailsVersionGroupDto VersionGroup { get; set; } = new();
}
