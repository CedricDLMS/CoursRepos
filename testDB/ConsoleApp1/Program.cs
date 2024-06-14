// See https://aka.ms/new-console-template for more information
using testDB;

Console.WriteLine("Hello, World!");

AppDBContext appDBContext = new AppDBContext();

Client c1 = new Client { Age = 1 , FirstName ="Jean Michel", LastName="Paulux" };
Client c2 = new Client {  FirstName ="Olivier", LastName ="Koenig", Age = 40 };

appDBContext.Clients.Add(c1);
appDBContext.Clients.Add(c2);

appDBContext.SaveChanges();