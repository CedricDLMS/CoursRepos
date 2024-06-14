using CrudMVC.Models;
using CrudMVC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CrudMVC.Controllers
{
	public class PokemonsController : Controller
	{
		private readonly PokemonContext context;
		private readonly PokemonRepository pokemonRepository;
		private readonly TypeRepository typeRepository;
		public PokemonsController(PokemonContext context, PokemonRepository repository, TypeRepository typeRepository)
		{
			this.context = context;
			this.pokemonRepository = repository;
			this.typeRepository = typeRepository;
		}
		public IActionResult Index()
		{
			return View();
		}
		public async Task<IActionResult> Get(int id)
		{
			ViewBag.Message = "Viewbag Message";
			return View(await this.pokemonRepository.Get(id));
		}
		[HttpGet]
		public async Task<IActionResult> Create()
		{
			return View(await typeRepository.GetAll());
		}
		[HttpPost]
		public async Task<IActionResult> Create(Pokemon pokemon)
		{
			try
			{
				await pokemonRepository.Create(pokemon);
				ViewBag.Message = "Create Reussis";
				return View();
			}catch (Exception ex)
			{
				ViewBag.Message = ex.Message;
				return View();
			}
		}
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			return View(await  pokemonRepository.GetAll());
		}
	}
}
