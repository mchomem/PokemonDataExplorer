namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class PastTypeDto
{
    [JsonPropertyName("generation")]
    public PastTypeGenerationDto Generation { get; set; } = new();

    [JsonPropertyName("types")]
    public IEnumerable<PastTypeTypeDto> Types { get; set; } = Enumerable.Empty<PastTypeTypeDto>();
}
