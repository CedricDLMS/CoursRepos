using Controllers;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class MenuIU
    {
        private readonly EmployeController _employeController;
        public MenuIU(EmployeController employeController)
        {
            this._employeController = employeController;
        }

        public async Task Menu()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("------BIENVENUE-------");
            Console.WriteLine("----------------------");
            Console.WriteLine("CHOOSE AN ACTION");
            Console.WriteLine("1 - Add Employee");
            Console.WriteLine("2 - Show all Employee");
            await Select();
            Console.ReadLine();
            Console.Clear();
        }
        public async Task Select()
        {
            var key = Console.ReadKey();

            if(key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
            {
                Console.WriteLine("You chose to add an employee");
                await addEmployee();
                
            }
            if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
            {
                Console.WriteLine("You chose to Show All Employees");
                await getAllEmployees();
                
            }

        }
        public async Task<Employe> addEmployee()
        {
            Console.WriteLine("Write Employe FirstName : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Write Employe LastName : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Write Employe Salary : ");
            string salaryS = Console.ReadLine();
            double salary = 0;
            double.TryParse(salaryS, out salary);

            //Employe employe = new Employe() { Id = 0, FirstName = firstName, LastName = lastName, Salary = salary };

            var returnedEmploye = await _employeController.Add(firstName, lastName, salary);
            await Console.Out.WriteLineAsync(returnedEmploye.ToString());
            return returnedEmploye;
        }
        public async Task getAllEmployees()
        {
            var employeeList = await _employeController.GetAll();
            foreach (var item in employeeList)
            {
                await Console.Out.WriteLineAsync(item.ToString());
            }
        }
    }
}
