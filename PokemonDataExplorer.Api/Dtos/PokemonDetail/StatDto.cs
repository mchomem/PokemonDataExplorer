namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class StatDto
{
    [JsonPropertyName("base_stat")]
    public int BaseStat { get; set; }

    [JsonPropertyName("effort")]
    public int Effort { get; set; }

    [JsonPropertyName("stat")]
    public StatDetailDto Stat { get; set; } = new();
}
