namespace CrudMVC.Models
{
	public class Pokemon
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int PokeTypeId { get; set; }
		public PokeType PokemonType { get; set; }
		public Pokemon()
		{

		}
		public Pokemon(int id, string name, int pokeTypeId)
		{
			Id = id;
			Name = name;
			PokeTypeId = pokeTypeId;
		}
	}
}
