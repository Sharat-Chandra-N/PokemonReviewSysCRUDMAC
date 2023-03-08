using System;
namespace PokemonReviewSys.Modals
{
	public class Country
	{
		public int Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public ICollection<Owner>? Owners { get; set; }
	}
}

