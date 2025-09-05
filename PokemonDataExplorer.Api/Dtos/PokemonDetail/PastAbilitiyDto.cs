namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class PastAbilitiyDto
{
    [JsonPropertyName("abilities")]
    public IEnumerable<PastAbilitiyAbilitiyDto> Abilities { get; set; } = Enumerable.Empty<PastAbilitiyAbilitiyDto>();

    [JsonPropertyName("generation")]
    public PastAbilityGenerationDto Generation { get; set; } = new();
}
