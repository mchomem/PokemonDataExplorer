namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class GameIndiceDto
{
    [JsonPropertyName("game_index")]
    public int GameIndex { get; set; }
    
    [JsonPropertyName("version")]
    public GameIndiceVersionDto VersionDto { get; set; } = new();

}
