using humains;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Personne cedric = new Personne("Delmas","Cedric");
Employee mich = new Employee("Jean", "Michel", 105000);
Employee gerrard = new Employee("HOUS", "Gerrard", 25000);
Personne lulu = new Personne("LOUISON", "Luise");


Personne[] tableauPersonnes = new Personne[4]
{
    cedric,
    mich,
    gerrard,
    lulu
};

IHumain[] humains = new IHumain[4]
{
    cedric,
    mich,
    gerrard,
    lulu
};

foreach(Personne person in humains)
{
    if (person is Employee)
    {
        Console.WriteLine($"{person.Nom} {person.Prenom} est un Employee Humain");
    }
    else
    {
        Console.WriteLine($"{person.Nom} {person.Prenom} est un Humain");
    }
}

//foreach (Personne person in tableauPersonnes)--------------------------------------------------------------------------------------------------------------------------
//{
//    Console.WriteLine(person);
//}