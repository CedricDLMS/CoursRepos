// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using System.Text;
using asynchronite;

//Console.ResetColor();

//Task tacheEcrire = FileHelp.EcrireAsync("test.txt");

//await FileHelp.AfficherAsync("test.txt");

//await tacheEcrire;

//await FileHelp.AfficherAsync("test.txt");

MyPair<int, string> test = new MyPair<int,string>(1,"deux") ;
Console.WriteLine(test.ToString());

MyPair<double, string> tt = new MyPair<double, string>(1.5, "deux");

Console.WriteLine(tt.ToString());