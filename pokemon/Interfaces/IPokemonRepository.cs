using Pokemon_review.Models;

namespace Pokemon_review.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<pokemon> GetPokemons();
    }
}
