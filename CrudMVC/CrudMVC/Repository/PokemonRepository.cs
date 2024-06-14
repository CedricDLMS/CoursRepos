using CrudMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudMVC.Repository
{
	public class PokemonRepository
	{
		private readonly PokemonContext _context;
		public PokemonRepository(PokemonContext pokemonContext)
		{
			this._context = pokemonContext;
		}

		public async Task<int> Create(Pokemon pokemon)
		{
			await _context.Pokemons.AddAsync(pokemon);
			int saves = await _context.SaveChangesAsync();

			return saves;
		}
		public async Task<Pokemon> Get(int id)
		{
			Pokemon? pokemon = await _context.Pokemons.FindAsync(id);

			if (pokemon == null)
			{
				throw new Exception("Pokemon not found");
			}
			else
			{
				return pokemon;
			}
		}

		public async Task<int> Update(Pokemon pokemon)
		{
			try
			{
				var oldPokemon = await this.Get(pokemon.Id);

				oldPokemon.Name = pokemon.Name;
				oldPokemon.PokeTypeId = pokemon.PokeTypeId;
				_context.Update(oldPokemon);
				return await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}

		public async Task<int> Delete(int Id)
		{
			try
			{
				Pokemon pokemon = await this.Get(Id);
				_context.Pokemons.Remove(pokemon);
				return await _context.SaveChangesAsync();
			}catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public async Task<List<Pokemon>> GetAll()
		{
			return await this._context.Pokemons.ToListAsync();
		}
	}
}
