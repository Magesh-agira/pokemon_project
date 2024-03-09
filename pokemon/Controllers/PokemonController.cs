using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Pokemon_review.Interfaces;

namespace Pokemon_review.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }
    }
}
