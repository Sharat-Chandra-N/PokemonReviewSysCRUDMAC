using System;
namespace PokemonReviewSys.Modals
{
	public class Owner
	{
		public int Id { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Gym { get; set; } = String.Empty;
		public Country? Country { get; set; }
        public ICollection<PokemonOwner>? PokemonOwners { get; set; }
    }	
}

