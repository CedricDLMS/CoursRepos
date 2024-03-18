using System.Threading.Channels;

namespace humains
{
    public interface IHumain
    {
        string Afficher();
    }
    public class Personne : IHumain
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateOnly? dateNassance { get; set; } = null;


        public string MajPrenom()
        {
            return Prenom = Prenom.ToUpper();
        }
        public Personne() { }
        public Personne(string Nom, string Prenom)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
        }
        public static void Test()
        {
            string DefaultS = "Default";
            int DefaultInt = 0;
            int nouveauInt;
            string nouveauS;
            Console.WriteLine($"Nous avons par défault en Str : {DefaultS} et en Int : {DefaultInt}");
            Console.WriteLine("Renseignons en des nouveaux");
        }

        public virtual string Afficher()
        {
            return $"{Nom} {Prenom}  née le : {(dateNassance?.ToString() ?? " Non-Renseignée ")}";
        }
        public override string ToString()
        {
            return Afficher();
        }
    }
    public class Employee : Personne
    {
        double Salaire { get; set; }

        public Employee(string nom, string Prenom, double Salaire) : base(nom, Prenom)
        {
            this.Salaire = Salaire;
        }
        public override string Afficher()
        {
            return base.Afficher() + " Salaire de: " + Salaire.ToString("C");
        }
        public override string ToString()
        {
            return Afficher();
        }
    }

    public class Eleve
    {
        public string? nom { get; set; }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 18 || value > 26)
                {
                    throw new InvalidAgeException();
                }
                else
                {
                    _age = value;
                    //Console.WriteLine("Rentrez un nouvel age");
                    //this.age = Int32.Parse(Console.ReadLine());
                }
            }
        }
        private int _moyenne;
        public int moyenne
        {
            get
            {
                return _moyenne;
            }
            set
            {
                if (value < 0 || value > 20)
                {
                    throw new InvalideNoteException();
                }
                else
                {
                    _moyenne = value;
                    //Console.WriteLine("Rentrez un nouvel age");

                }
            }
        }


        public Eleve() { }
        public Eleve(string nom, int sage, int moyenne)
        {
            this.nom = nom;
            this.Age = sage;
            this.moyenne = moyenne;
        }


    }
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException() : base("Age invalide") { }
    }
    public class InvalideNoteException : Exception
    {
        public InvalideNoteException() : base("NOTE INVALIDE") { }
    }
}