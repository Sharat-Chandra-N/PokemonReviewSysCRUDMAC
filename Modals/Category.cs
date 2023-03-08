using System;
namespace PokemonReviewSys.Modals
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public ICollection<PokemonCategory>? PokemonCategories { get; set; }
	}
}

