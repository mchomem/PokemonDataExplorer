namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class PokemonAbilityDto
{
    [JsonPropertyName("ability")]
    public PokemonAbilityAbilityDto Ability { get; set; } = new();

    [JsonPropertyName("is_hidden")]
    public bool IsHidden { get; set; }

    [JsonPropertyName("slot")]
    public int Slot { get; set; }
}
