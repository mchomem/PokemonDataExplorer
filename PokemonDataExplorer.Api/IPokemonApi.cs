using PokemonDataExplorer.Api.Dtos.PokemonDetail;

namespace PokemonDataExplorer.Api;

public interface IPokemonApi
{
    [Get("/pokemon/{name}")]
    Task<PokemonDto> GetPokemonAsync(string name);

    [Get("/pokemon/")]
    Task<PokemonListDto> GetAllPokemonsAsync(int? offset, int? limit);
}
