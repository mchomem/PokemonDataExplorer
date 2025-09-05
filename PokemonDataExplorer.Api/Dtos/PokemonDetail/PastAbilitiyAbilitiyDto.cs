namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

public class PastAbilitiyAbilitiyDto
{
    [JsonPropertyName("ability")]
    public string Ability { get; set; } = string.Empty;

    [JsonPropertyName("is_hidden")]
    public bool IsHidden { get; set; }

    [JsonPropertyName("slot")]
    public int Slot { get; set; }
}
