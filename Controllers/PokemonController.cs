using System;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewSys.Interfaces;
using PokemonReviewSys.Modals;

namespace PokemonReviewSys.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PokemonController : Controller
	{
		private readonly IPokemonRepository _pokemonRepository;

		public PokemonController(IPokemonRepository pokemonRepository)
		{
			_pokemonRepository = pokemonRepository;
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
		public IActionResult GetPokemons()
		{
			var pokemons = _pokemonRepository.GetPokemons();

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			return Ok(pokemons);
		}
	}
}

