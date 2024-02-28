namespace Pokemon_review.Models
{
    public class PokemonOwner
    {
        public int PokemonId { get; set; }
        public int OwnerId { get; set; }
        public pokemon Pokemon { get; set; }
        public Owner Owner { get; set; }
    }
}
