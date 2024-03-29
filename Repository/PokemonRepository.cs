﻿using System;
using PokemonReviewSys.Data;
using PokemonReviewSys.Interfaces;
using PokemonReviewSys.Modals;

namespace PokemonReviewSys.Repository
{
	public class PokemonRepository : IPokemonRepository
	{
		private readonly DataContext _context;

		public PokemonRepository(DataContext context)
		{
			_context = context;
		}

		public ICollection<Pokemon> GetPokemons()
		{
			return _context.Pokemons.OrderBy(p => p.Id).ToList();
		}
	}
}

