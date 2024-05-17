using Business;
using Business.Contracts;
using Entities;

namespace Controllers
{
    public class EmployeController
    {
        private readonly IEmployeBusiness employeBusiness;
        public EmployeController(IEmployeBusiness _employeBusiness)
        {
            this.employeBusiness = _employeBusiness;
        }

        public async Task<Employe> Add(string firstName,string lastName,double salary)
        {
            Employe employe = new Employe() {Id=0, FirstName = firstName, LastName = lastName, Salary = salary };
            try
            {
                return await employeBusiness.addEmploye(employe);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task<List<Employe>?> GetAll()
        {
            try
            {
                return await employeBusiness.getAllEmployesAsync();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
