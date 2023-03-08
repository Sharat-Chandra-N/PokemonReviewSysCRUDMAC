using System;
namespace PokemonReviewSys.Modals
{
	public class Owner
	{
		public int Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public string Gym { get; set; } = String.Empty;
		public Country? Country { get; set; } 
    }	
}

