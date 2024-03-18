using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ioConsoleApp
{
    internal class Personne
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public Personne() { }
        public Personne(string name,string surname)
        {
            Name = name;
            FirstName = surname;
        }
    }
}
