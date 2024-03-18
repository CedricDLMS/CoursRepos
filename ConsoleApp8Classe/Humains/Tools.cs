using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humains
{
    public class Tools
    {
        public static int getIntFromConsole()
        {
            int I;
            Console.WriteLine("Renseignez un chiffre");
            I = int.Parse(Console.ReadLine());
            return I;
        }
        public static string getStringFromConsole()
        {
            string I;
            Console.WriteLine("Renseignez un texte ");
            I = Console.ReadLine();
            return I;
        }
    }
}
