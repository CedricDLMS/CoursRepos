namespace CrudMVC.Models
{
	public class PokeType
	{
		public int Id { get; set; }
		public string Name { get; set; }
		// EF NAVIGATION

		public List<Pokemon>? Pokemons { get; set; }
	}
}
