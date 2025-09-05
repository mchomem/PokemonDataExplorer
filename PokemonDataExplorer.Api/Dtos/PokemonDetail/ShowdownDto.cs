namespace PokemonDataExplorer.Api.Dtos.PokemonDetail
{
    public class ShowdownDto
    {
        [JsonPropertyName("back_default")]
        public string BackDefault { get; set; } = string.Empty;

        [JsonPropertyName("back_female")]
        public string BackFemale { get; set; } = string.Empty;

        [JsonPropertyName("back_shiny")]
        public string BackShiny { get; set; } = string.Empty;

        [JsonPropertyName("back_shiny_female")]
        public string BackShinyFemale { get; set; } = string.Empty;

        [JsonPropertyName("front_default")]
        public string FrontDefault { get; set; } = string.Empty;

        [JsonPropertyName("front_female")]
        public string FrontFemale { get; set; } = string.Empty;

        [JsonPropertyName("front_shiny")]
        public string FrontShiny { get; set; } = string.Empty;

        [JsonPropertyName("front_shiny_female")]
        public string FrontShinyFemale { get; set; } = string.Empty;
    }
}
