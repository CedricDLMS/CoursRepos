using Business.Contracts;
using Entities;
using Repository;
using Repository.Contracts;

namespace Business
{
    public class EmployeBusiness : IEmployeBusiness
    {
        private readonly IEmployeRepository employeRepository;
        public EmployeBusiness(IEmployeRepository _employeRepository)
        {
            this.employeRepository = _employeRepository;
        }

        public async Task<Employe> addEmploye(Employe employe)
        {
            if(employe == null) { throw new ArgumentNullException(message: "employee can't be null", paramName: "employee"); }
            if(employe.Salary <= 0) { throw new Exception("Salaire must exceed 0"); }
            if(employe.FirstName.Count() <= 2) { throw new Exception("FirstName invalid"); }
            if(employe.LastName.Count() <= 2) { throw new Exception("LastName invalid");}

            employe.FirstName.ToLower();
            employe.LastName.ToUpper();

            return await employeRepository.addEmployeAsync(employe);
        }
        public async Task<List<Employe>?> getAllEmployesAsync()
        {
            var employesList = await employeRepository.getAllEmployeAsync();
            if(employesList == null) { throw new Exception("No user Found"); }
            return employesList;
        }
    }
}
