using System;
namespace PokemonReviewSys.Modals
{
	public class Reviewer
	{
        public int id { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public ICollection<Review>? Reviews { get; set; }
    }
}

