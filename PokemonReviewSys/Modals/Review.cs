using System;
namespace PokemonReviewSys.Modals
{
	public class Review
	{
		public int id { get; set; }
		public string Title { get; set; } = String.Empty;
		public string Text { get; set; } = String.Empty;
        public int Rating { get; set; }
        public Pokemon? Pokemon { get; set; }
        public Reviewer? Reviewer { get; set; }
    }
}

