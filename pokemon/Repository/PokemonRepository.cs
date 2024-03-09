using Pokemon_review.Data;
using Pokemon_review.Models;

namespace Pokemon_review.Repository
{
    public class PokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList().ToList();

        }
    }
}
