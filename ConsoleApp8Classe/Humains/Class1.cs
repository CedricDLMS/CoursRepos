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
}
