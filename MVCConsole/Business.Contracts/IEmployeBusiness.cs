using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contracts
{
    public interface IEmployeBusiness
    {
        public Task<Employe> addEmploye(Employe employe);
        public Task<List<Employe>?> getAllEmployesAsync();
    }
}
