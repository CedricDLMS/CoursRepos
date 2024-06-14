using CrudMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudMVC.Repository
{
	public class TypeRepository
	{
        private readonly PokemonContext _context;
        public TypeRepository(PokemonContext pokemonContext)
        {
            this._context = pokemonContext;
        }

        public async Task<int> Create(PokeType type)
        {
            await _context.Types.AddAsync(type);
            int saves = await _context.SaveChangesAsync();

            return saves;
        }
        public async Task<PokeType> Get(int id)
        {
            PokeType? type = await _context.Types.FindAsync(id);

            if (type == null)
            {
                throw new Exception("Pokemon not found");
            }
            else
            {
                return type;
            }
        }

        public async Task<int> Update(PokeType type)
        {
            try
            {
                var oldType = await this.Get(type.Id);

                oldType.Name = type.Name;
                _context.Update(oldType);
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
                PokeType type = await this.Get(Id);
                _context.Types.Remove(type);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<List<PokeType>> GetAll()
        {
            return await _context.Types.ToListAsync();
        }
    }

}
