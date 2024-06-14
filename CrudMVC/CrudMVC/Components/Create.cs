using CrudMVC.Models;
using CrudMVC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CrudMVC.Components
{
	public class Create : ViewComponent
	{
		private readonly PokemonContext context;
		private readonly PokemonRepository pokemonRepository;
		private readonly TypeRepository typeRepository;
		public Create(PokemonContext context, PokemonRepository repository, TypeRepository typeRepository)
		{
			this.context = context;
			this.pokemonRepository = repository;
			this.typeRepository = typeRepository;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View(await typeRepository.GetAll());
		}
	}
}
