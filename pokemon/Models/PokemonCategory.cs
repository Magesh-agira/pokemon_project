namespace Pokemon_review.Models
{
    public class PokemonCategory
    {
        public int PokemonId { get; set; }
        public int CategoryId { get; set; }
        public pokemon Pokemon { get; set; }
        public Category Category { get; set; }
    }
}
