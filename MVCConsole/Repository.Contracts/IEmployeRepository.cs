using Entities;

namespace Repository.Contracts
{
    public interface IEmployeRepository
    {
        public Task<Employe> addEmployeAsync(Employe employe);
        public Task<List<Employe>?> getAllEmployeAsync();
    }
}
