using Entities;
using Repository.Contracts;

namespace Repository
{
    public class EmployeRepository : IEmployeRepository
    {
        private readonly LocalStorage _storage;
        public EmployeRepository(LocalStorage localStorage) 
        {
            this._storage = localStorage;
        }

        public async Task<Employe> addEmployeAsync(Employe employe)
        {
            employe.Id = (_storage.Employes.Count)+1;
            _storage.Employes.Add(employe);

            return employe;
        }
        public async Task<List<Employe>?> getAllEmployeAsync()
        {
            return _storage.Employes;
        }

    }
}
