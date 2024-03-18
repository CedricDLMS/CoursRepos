// See https://aka.ms/new-console-template for more information
using ioConsoleApp;
using System.Text.Json;

var listePersonne = new List<Personne>();

listePersonne.Add(new Personne("cedric","delmas"));
listePersonne.Add(new Personne("gerard", "tocco"));
listePersonne.Add(new Personne("laurent", "first"));
listePersonne.Add(new Personne("laurentmich", "eat"));
listePersonne.Add(new Personne("lili","tutu"));
listePersonne.Add(new Personne("audrey", "paulhe"));
listePersonne.Add(new Personne("polu", "stora"));
listePersonne.Add(new Personne("tony", "starck"));

string nomFichier = "personne.json";

//string jsonString = JsonSerializer.Serialize(listePersonne);
//File.WriteAllText(nomFichier, jsonString);

var contenuFichier = File.ReadAllText("jsonToTxt.txt");
File.WriteAllText("jsonFromTxt.json", contenuFichier);

//var p2 = JsonSerializer.Deserialize<Personne>(contenuFichier);


//using (StreamWriter file = new StreamWriter("jsonToTxt.txt"))
//{
//    file.Write(JsonSerializer.Serialize(listePersonne));
//    using (StreamWriter fileNew = new StreamWriter("jsonFromTxt.json"))
//    {
//        fileNew.Write(JsonSerializer.Serialize(file.ToString()));
//    }
//}

//using (StreamWriter file = new StreamWriter("jsonFromTxt.json"))
//{

//}

var contenuPng = File.ReadAllText("fluctuation.png");

using (StreamReader reader = new StreamReader("fluctuation.png"))
{
    BinaryReader gogo = new BinaryReader(reader.BaseStream);
    var yoyo = gogo.ReadBytes(50000);
    foreach(var item in yoyo)
    {
        Console.WriteLine(item);
    }
}



