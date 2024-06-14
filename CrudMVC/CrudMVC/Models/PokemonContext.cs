using Microsoft.EntityFrameworkCore;

namespace CrudMVC.Models
{
	public class PokemonContext : DbContext
	{
		public PokemonContext(DbContextOptions optionsBuilder) : base(optionsBuilder) { }
		public DbSet<Pokemon> Pokemons { get; set; }
		public DbSet<PokeType> Types { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PokemonDb;Trusted_Connection=True;");
			}
			base.OnConfiguring(optionsBuilder);
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			PokeType poison = new PokeType { Id = 1, Name = "poison" };
			Pokemon Oulou = new Pokemon(1, "oulou", 1);
			
			modelBuilder.Entity<PokeType>().HasData(poison);
			modelBuilder.Entity<Pokemon>().HasData(Oulou);
			base.OnModelCreating(modelBuilder);
			
		}
	}
}
