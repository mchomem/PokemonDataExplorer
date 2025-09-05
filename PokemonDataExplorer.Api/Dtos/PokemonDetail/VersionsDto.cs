namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class VersionsDto
{
    [JsonPropertyName("generation-i")]
    public GenerationIDto GenerationI { get; set; } = new();

    [JsonPropertyName("generation-ii")]
    public GenerationIIDto GenerationII { get; set; } = new();

    // TODO: finalizar as outras gerações: 3, 4, 5, 6, 7 e 8. Vide arquivo modelo no diretório ExampleJson/pokemon.json.
}
