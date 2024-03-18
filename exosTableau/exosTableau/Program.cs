using System.Dynamic;
using System.Security.Cryptography;
using humains;

void exo30()
{
    int[] tableau = new int[15];

    for (int i = 0; i < 15; i++)
    {
        tableau[i] = RandomNumberGenerator.GetInt32(0, 100);
    }

    Console.ForegroundColor = ConsoleColor.Green;
    foreach (int i in tableau)
    {
        Console.WriteLine(i);
    }

    Console.ForegroundColor = ConsoleColor.Red;
    Array.Sort(tableau);
    foreach (int i in tableau)
    {
        Console.WriteLine(i);
    }
}

string motRandom(int longueurMot)
{
    string monMot = "";
    for (int i = 0; i < longueurMot; i++)
    {
        int z = RandomNumberGenerator.GetInt32(1, 25);
        char a = (char)('a' + z);
        monMot += a.ToString();
    }
    return monMot;
}

void exo31()
{
    List<string> tableauMots = new();

    for (int i = 0; i < 15; i++)
    {
        tableauMots.Add(motRandom(5));
    }
    Console.ForegroundColor = ConsoleColor.Red;
    foreach (string i in tableauMots)
    {
        Console.WriteLine(i);
    }
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("---ET MAINTENANT LISTE CLASSE---");
    Console.ForegroundColor = ConsoleColor.White;
    tableauMots.Sort();
    Console.ForegroundColor = ConsoleColor.Green;
    foreach (string i in tableauMots)
    {
        Console.WriteLine(i);
    }
    Console.ForegroundColor = ConsoleColor.White;
}


void linq1()
{
    List<int> ints = new List<int>();
    for (int i = 0; i < 5; i++)
    {
        ints.Add(RandomNumberGenerator.GetInt32(0, 100));
        Console.WriteLine(ints[i]);
    }
    Console.WriteLine("Ceci est la somme : " + ints.Sum());
}

void linq2()
{
    List<int> ints = new List<int>();
    for (int i = 0; i < 5; i++)
    {
        ints.Add(RandomNumberGenerator.GetInt32(0, 20));
        Console.WriteLine(ints[i]);
    }
    Console.WriteLine("Ceci est la moyenne : " + ints.Average());
}

void linq3()
{
    List<int> ints = new List<int>();
    for (int i = 0; i < 10; i++)
    {
        ints.Add(RandomNumberGenerator.GetInt32(0, 20));
        Console.WriteLine(ints[i]);
    }
    List<int> intSup6 = ints.Where(x => x > 6).ToList();
    Console.WriteLine("------CI DESSOUS NB sup 6-------");
    foreach (var item in intSup6)
    {
        Console.WriteLine(item);
    }
}

void linq4()
{
    List<int> ints = new List<int>();
    for (int i = 0; i < 10; i++)
    {
        ints.Add(RandomNumberGenerator.GetInt32(0, 20));
        Console.WriteLine(ints[i]);
    }
    List<int> intSup6 = ints.Where(x => x > 6).ToList();
    Console.WriteLine("------CI DESSOUS NB sup 6-------");
    foreach (var item in intSup6)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("Il y en a : " + intSup6.Count());
}


void linq5()
{
    List<Personne> personnes = new List<Personne>();
    personnes.Add(new Personne("DELMAS", "Cedric"));
    personnes.Add(new Personne("TOCCO", "Florian"));
    personnes.Add(new Personne("ACKET", "Greg"));
    personnes.Add(new Personne("KOENIG", "Olivier"));
    personnes.Add(new Personne("THEVENET", "Elsa"));
    personnes.Add(new Personne("ZAOUI", "Mohamed"));
    personnes.Add(new Personne("DUPONT", "Louis"));
    personnes.Add(new Personne("DUPONT", "Anthoine"));
    personnes.Add(new Personne("DUPONT", "Anaele"));
    var ranking = personnes.OrderBy(p => p.Nom).ThenBy(p => p.Prenom).ToList();
    foreach (var item in ranking)
    {
        Console.WriteLine(item.Prenom + " " + item.Nom);
    }
}

void linq6()
{
    List<Personne> personnes = new List<Personne>();
    personnes.Add(new Personne("DELMAS", "Cedric"));
    personnes.Add(new Personne("TOCCO", "Florian"));
    personnes.Add(new Personne("ACKET", "Greg"));
    personnes.Add(new Personne("KOENIG", "Olivier"));
    personnes.Add(new Personne("THEVENET", "Elsa"));
    personnes.Add(new Personne("ZAOUI", "Mohamed"));
    personnes.Add(new Personne("DUPONT", "Louis"));
    personnes.Add(new Personne("DUPONT", "Anthoine"));
    personnes.Add(new Personne("DUPONT", "Anaele"));
    Console.WriteLine("Une liste de personnes :");
    foreach (var item in personnes)
    {
        Console.WriteLine(item.Nom + " " + item.Prenom);
    }

    var personneD = personnes.Where(p => p.Nom.StartsWith('D')).ToList();
    Console.WriteLine("Une liste de personnes dont le nom commence par D");
    foreach (var item in personneD)
    {
        Console.WriteLine(item.Nom + " " + item.Prenom);
    }
}
List<Personne> personnes = new List<Personne>();
personnes.Add(new Personne("DELMAS", "Cedric"));
personnes.Add(new Personne("TOCCO", "Florian"));
personnes.Add(new Personne("ACKET", "Greg"));
personnes.Add(new Personne("KOENIG", "Olivier"));
personnes.Add(new Personne("THEVENET", "Elsa"));
personnes.Add(new Personne("ZAOUI", "Mohamed"));
personnes.Add(new Personne("DUPONT", "Louis"));
personnes.Add(new Personne("DUPONT", "Anthoine"));
personnes.Add(new Personne("DUPONT", "Anaele"));
personnes.Add(new Personne("DELAVEGA", "Zorro"));
personnes.Add(new Personne("LABITE", "Louis"));
personnes.Add(new Personne("CLENCHE", "Louis"));

void linq7()
{
    Console.WriteLine("Une liste de personnes avec nom uniquement :");
    foreach (var item in personnes)
    {
        Console.WriteLine(item.Nom);
    }
}

void linq8()
{
    var personnes2 = personnes.Take(2).ToList();
    Console.WriteLine("deux premiers : ");
    foreach (var item in personnes2)
    {
        Console.WriteLine(item.Afficher());
    }
}

void linq9()
{
    var personnesPos = personnes.Skip(6).Take(3).ToList();
    Console.WriteLine("Les 7,8,9");
    foreach (var item in personnesPos)
    {
        Console.WriteLine(item.Nom + " " + item.Prenom);

    }
}

void linq10()
{
    var lesDup = personnes.Where(p => p.Nom == "DUPONT").ToList();
    Console.WriteLine("Les duponts :");
    foreach (var item in lesDup)
    {
        Console.WriteLine(item.Nom + " " + item.Prenom);
    }
}

void linq11()
{
    bool startWithD = personnes.Any(p => p.Nom.StartsWith('D'));
    if (startWithD)
    {
        Console.WriteLine("La liste contient personne nom commence par D");
    }
    else
    {
        Console.WriteLine("Pas de nom qui commence par D");
    }
}

void linq12()
{
    var prenomLenght = personnes.Sum(p => p.Prenom.Length);
    foreach (var item in personnes)
    {
        Console.WriteLine(item.Prenom + " " + item.Prenom.Length);
    }

    Console.WriteLine(prenomLenght.ToString());
}

void linq13()
{
    var prenomGroup = personnes.GroupBy(p => p.Prenom);
    foreach (var item in prenomGroup)
    {
        Console.WriteLine(item.Key);
        foreach (var personne in item)
        {
            Console.WriteLine($"\t {personne.Prenom}  {personne.Nom}");
        }
    }
}
void linq14()
{
    var ordre = personnes.Select(p => new { p.Prenom, Nom = p.Nom.ToUpper() }).Where(p => p.Nom.StartsWith('D')).OrderByDescending(p => p.Prenom);
    foreach (var item in ordre)
    {
        Console.WriteLine($"{item.Prenom}  {item.Nom}");
    }
}

void linq15()
{
    Console.WriteLine("Veuillez renseigner un premier nombre que nous allons diviser");
    int premierNombre = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Veuillez renseigner un deuxieme nombre qui divisera l'autre , NE CHOISISSEZ SURTOUT PAS 0");
    int deuxiemeNombre = Int32.Parse(Console.ReadLine());
    try
    {
        int resultat = premierNombre / deuxiemeNombre;
        Console.WriteLine($"Merci de ne pas avoir mis 0, le resultat est : {resultat}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Bravo vous avez essayer de diviser par 0 -_-' ");
    }

    int resultat2 = premierNombre / deuxiemeNombre;
}

void exo16()
{
    try
    {
    Eleve claude = new Eleve("Claude",18,22);

    }
    catch(InvalidAgeException ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine("erreur");
    }
    catch(InvalideNoteException i)
    {
        Console.WriteLine(i.Message);
    }
}
void IO()
{

}