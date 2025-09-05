namespace PokemonDataExplorer.Api.Dtos.PokemonDetail;

/// <summary>
/// Dados brutos (raw) que representa os dados de um Pokémon.
/// </summary>
public class PokemonDto
{
    [JsonPropertyName("abilities")]
    public IEnumerable<PokemonAbilityDto> Abilities { get; set; } = Enumerable.Empty<PokemonAbilityDto>();

    [JsonPropertyName("base_experience")]
    public int BaseExperience { get; set; }

    [JsonPropertyName("cries")]
    public CryDto Cries { get; set; } = new();

    [JsonPropertyName("forms")]
    public IEnumerable<Form> Forms { get; set; } = Enumerable.Empty<Form>();

    [JsonPropertyName("game_indices")]
    public IEnumerable<GameIndiceDto> GameIndices { get; set; } = Enumerable.Empty<GameIndiceDto>();

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("held_items")]
    public IEnumerable<HeldDto> HeldItems { get; set; } = Enumerable.Empty<HeldDto>();

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("is_default")]
    public bool IsDefault { get; set; }

    [JsonPropertyName("location_area_encounters")]
    public string LocationAreaEncounters { get; set; } = string.Empty;

    [JsonPropertyName("moves")]
    public IEnumerable<PokemonMoveDto> Moves { get; set; } = Enumerable.Empty<PokemonMoveDto>();

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("past_abilities")]
    public IEnumerable<PastAbilitiyDto> PastAbilities { get; set; } = Enumerable.Empty<PastAbilitiyDto>();

    [JsonPropertyName("past_types")]
    public IEnumerable<PastTypeDto> PastTypes { get; set; } = Enumerable.Empty<PastTypeDto>();

    [JsonPropertyName("species")]
    public SpecieDto Species { get; set; } = new();

    [JsonPropertyName("sprites")]
    public SpritesDto Sprites { get; set; } = new();

    [JsonPropertyName("stats")]
    public IEnumerable<StatDto> Stats { get; set; } = Enumerable.Empty<StatDto>();
    
    [JsonPropertyName("types")]
    public IEnumerable<TypeDto> Types { get; set; } = Enumerable.Empty<TypeDto>();
    
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
}
