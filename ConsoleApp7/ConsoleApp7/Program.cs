//// See https://aka.ms/new-console-template for more information

//using System.Globalization;
//using System.Reflection.Metadata.Ecma335;
//using System.Security.Cryptography;
////  ****** EX 2


////int convertAge(string x) 
////{
////    int age;
////    bool success = int.TryParse(x, out age);
////    return age;
////}
////string getName() 
////{
////    Console.WriteLine("Quel est ton nom");
////    string nameS = Console.ReadLine();

////    return nameS;
////}

////string getAge()
////{
////    Console.WriteLine("Quel est ton age ?");
////    string ageS = Console.ReadLine();
////    return ageS;
////}


////Console.WriteLine(getName());
////Console.WriteLine(convertAge(getAge()));


//// ****** EX 3

////string a = Console.ReadLine();
////string b = Console.ReadLine();
////string c = Console.ReadLine();

////Console.WriteLine(c);
////Console.WriteLine(b);
////Console.WriteLine(a);

//// *** EX 4 

////int a;
////int b;

////string aString = Console.ReadLine();
////string bString = Console.ReadLine();

////if(int.TryParse(aString, out a) == int.TryParse(bString, out b))
////{
////    if (a == b)
////    {
////        Console.WriteLine("Vos nombres sont égaux");
////    }else { Console.WriteLine("vos nombres sont différents"); }
////}

//// **** EX 5

////int a;
////int b;
////int c;

////Console.WriteLine("Entrez premier num");
////string aString = Console.ReadLine();
////Console.WriteLine("Entrez le deuxieme");
////string bString = Console.ReadLine();

////Console.WriteLine("a = " +  aString);
////Console.WriteLine("b = " +  bString);

////if (int.TryParse(aString, out a) == true && int.TryParse(bString, out b) == true)
////{
////    c = b;
////    b = a;
////    a = c;
////    Console.WriteLine("Et maintenant nous avons : ");
////    Console.WriteLine("a = ");
////    Console.WriteLine(a);
////    Console.WriteLine("b = ");
////    Console.WriteLine(b);
////}


//// ***** EX 6 

////int a;
////int b;

////Console.WriteLine("Entrez premier num");
////string aString = Console.ReadLine();
////Console.WriteLine("Entrez le deuxieme");
////string bString = Console.ReadLine();

////Console.WriteLine("a = " + aString);
////Console.WriteLine("b = " + bString);

////if (int.TryParse(aString, out a) == true && int.TryParse(bString, out b) == true)
////{
////    Console.WriteLine("Et maintenant nous avons : ");
////    Console.WriteLine("a + b = ");
////    Console.WriteLine(a + b);
////    Console.WriteLine("a - b = ");
////    Console.WriteLine(a - b);
////    Console.WriteLine("a * b = ");
////    Console.WriteLine(a * b);
////    Console.WriteLine("a / b = ");
////    Console.WriteLine(a / b);
////}


//// ***** ex 7 

////double a;
////double b;
////double c;

////Console.WriteLine("Entrez premier num");
////string aString = Console.ReadLine();
////Console.WriteLine("Entrez le deuxieme");
////string bString = Console.ReadLine();
////Console.WriteLine("Entrez le troisieme");
////string cString = Console.ReadLine();

////Console.WriteLine("a = " + aString);
////Console.WriteLine("b = " + bString);
////Console.WriteLine("c = " + cString);

////if (double.TryParse(cString, out c) == true && double.TryParse(aString, out a) == true && double.TryParse(bString, out b) == true)
////{
////    double moyenne = (a + b + c) / 3;
////    Console.WriteLine(moyenne);
////}


//// ****** ex 9 

////int a; 
////string aString = Console.ReadLine();
////if (int.TryParse(aString, out a))
////{
////    if (a > 0)
////    {
////        Console.WriteLine("votre nombre est positif");
////    }
////    else
////    {
////        Console.WriteLine("votre nombre est négatif");
////    }
////}

//// ****** ex 10

////int a;
////string aString = Console.ReadLine();
////if (int.TryParse(aString, out a))
////{
////    if (a%2 == 0)
////    {
////        Console.WriteLine("votre nombre est pair");
////    }
////    else
////    {
////        Console.WriteLine("votre nombre est impair");
////    }
////}


//// ******* ex 11 
////double degresCelsius;
////Console.WriteLine("Rentrez la température en Celsius");
////degresCelsius = double.Parse(Console.ReadLine());

////double convertKelvin(double x) 
////{
////    double kelvin = x + 273.15;
////    //double farenheit = ((x*18)/10)+32;
////    return kelvin;
////}
////double convertFarenheit(double x)
////{
////    //double kelvin = x + 273.15;
////    double farenheit = ((x * 18) / 10) + 32;
////    return farenheit;
////}
////Console.WriteLine("Cela fait en Kelvin :");
////Console.WriteLine(convertKelvin(degresCelsius));
////Console.WriteLine("Cela fait en Farenheit :");
////Console.WriteLine(convertFarenheit(degresCelsius));

//// ***** ex 12

////Console.WriteLine("Rentrez un jour :");
////string jour = Console.ReadLine();

////switch (jour) 
////{
////    case "lundi":
////        Console.WriteLine("nous sommes lundi");
////        break;
////    case "mardi":
////        Console.WriteLine("nous sommes mardi");
////        break;
////    case "mercredi":
////        Console.WriteLine("nous sommes mercredi");
////        break;
////    case "jeudi":
////        Console.WriteLine("nous sommes jeudi");
////        break;
////    case "vendredi":
////        Console.WriteLine("nous sommes vendredi");
////        break;
////    case "samedi":
////        Console.WriteLine("nous sommes samedi");
////        break;
////    case "dimanche":
////        Console.WriteLine("nous sommes dimanche");
////        break;
////}


//// ***** ex 13 

////Console.WriteLine("Rentrez un jour :");
////string jour = Console.ReadLine();

////switch (jour)
////{
////    case "lundi":
////        Console.WriteLine("nous sommes lundi");

////        break;
////    case "mardi":
////        Console.WriteLine("nous sommes mardi");
////        break;
////    case "mercredi":
////        Console.WriteLine("nous sommes mercredi");
////        break;
////    case "jeudi":
////        Console.WriteLine("nous sommes jeudi");
////        break;
////    case "vendredi":
////        Console.WriteLine("nous sommes vendredi");
////        break;
////    case "samedi":
////        Console.WriteLine("nous sommes samedi");
////        break;
////    case "dimanche":
////        Console.WriteLine("nous sommes dimanche");
////        break;
////}

//// ****** ex 14 

////Console.WriteLine("rentrez un premier chiffre");
////double a = double.Parse(Console.ReadLine());
////Console.WriteLine("Rentrez un opérateur : '*', '+', '/', '-' ");
////string operateur = Console.ReadLine();
////Console.WriteLine("rentrez un deuxieme chiffre");
////double b = double.Parse(Console.ReadLine());

////switch (operateur)
////{
////    case "*":
////        Console.WriteLine("Le résultat a multiplie b est :");
////        Console.WriteLine(a * b);
////        break;
////    case "/":
////        Console.WriteLine("Le résultat a divise b est :");
////        Console.WriteLine(a / b);
////        break;
////    case "+":
////        Console.WriteLine("Le résultat de l'addition est :");
////        Console.WriteLine(a + b);
////        break;
////    case "-":
////        Console.WriteLine("Le résultat de la soustration de a moins b est :");
////        Console.WriteLine(a - b);
////        break;
////}

//// ******* ex 15 

////for(int i = 0; i < 11; i++)
////{
////    Console.WriteLine(i);
////} 

//// ******* ex 16

////for (int i = 0; i < 11; i++)
////{
////    Console.WriteLine($"Nous avons pour la table{i}");
////    for (int k = 0;k<11; k++)
////    {
////        Console.WriteLine(i * k);
////    }
////}

//// ******* ex 17

////Console.WriteLine("rentrez une lettre");
////char a = char.Parse(Console.ReadLine());
////Console.WriteLine("rentrez la base du triangle");
////int b = int.Parse(Console.ReadLine());

////for (int i = b; i >= 0; i--)
////{
////    char c = a;
////    Console.WriteLine(new string(c, i));
////}

//// ****** ex 18 


////Console.WriteLine("rentrez une lettre");
////char a = char.Parse(Console.ReadLine());
////Console.WriteLine("rentrez la base du triangle");
////int b = int.Parse(Console.ReadLine());

////for (int i = 1; i <= b; i++)
////{
////    // Espaces à gauche
////    for (int j = b; j > i; j--)
////    {
////        Console.Write(" ");
////    }

////    // Affichage des caractères
////    for (int k = 1; k <= (2 * i - 1); k++)
////    {
////        Console.Write(a);
////    }

////    // Passage à la ligne suivante
////    Console.WriteLine();
////}


//// ***** ex 19


////Console.WriteLine("rentrez une lettre");
////char a = char.Parse(Console.ReadLine());
////Console.WriteLine("rentrez la base du triangle");
////int b = int.Parse(Console.ReadLine());

////for (int i = 1; i <= b; i++)
////{
////    for (int j = b; j > i; j--)
////    {
////        Console.Write(" ");
////    }

////    for (int k = 1; k <= (2 * i - 1); k++)
////    {
////        Console.Write(a);
////    }


////    Console.WriteLine();
////}
////for (int i = b-1; i >= 0; i--)
////{
////    for (int j = b; j > i; j--)
////    {
////        Console.Write(" ");
////    }

////    for (int k = 1; k <= (2 * i - 1); k++)
////    {
////        Console.Write(a);
////    }

////    Console.WriteLine();
////}



//// ***** ex 20

////DateTime dateTime = DateTime.Now;
////Console.WriteLine(dateTime);
////Console.WriteLine(dateTime.ToString("MM/dd/yyyy") + dateTime.ToString("dddd dd MMMM"));

//// ******* ex 21 

////string dateAnnee = Console.ReadLine();
////string dateMois = Console.ReadLine();
////string dateJour = Console.ReadLine();

////DateTime date = new DateTime(Int32.Parse(dateAnnee), Int32.Parse(dateMois), Int32.Parse(dateJour));
////DateTime current = DateTime.Now;
////DateTime zeroTime = new DateTime(1, 1, 1);

////TimeSpan span = current - date;
////int years = (zeroTime + span).Year - 1;


////Console.WriteLine("en Français : " + date.ToString("dddd dd MMMM yyyy"));
////Console.WriteLine("en Anglais : " + date.ToString("dddd dd MMMM yyyy", new CultureInfo("en-EN")));
////Console.WriteLine("Difference de " + years + "annee");


//// ********** exercice annexe 


//// -----------------------------------PAS BON 

////string[,] tableau = new string[100, 50];
////void creerTableau(int l, int h)
////{

////    for (int i = 0; i < h; i++)
////    {
////        for (int j = 0; j < l; j++)
////        {
////            tableau[j, i] = ".";
////        }
////    }

////    //for (int i = 0; i<h;i++)
////    //{
////    //    for( int j = 0; j < l; j++)
////    //    {
////    //    Console.Write(tableau[j,i]);
////    //    }
////    //    Console.WriteLine("");
////    //}
////}

////void afficherTableau(int l, int h)
////{
////    for (int i = 0; i < h; i++)
////    {
////        for (int j = 0; j < l; j++)
////        {
////            Console.Write(tableau[j, i]);
////        }
////        Console.WriteLine();
////    }
////}

////void dessineCercle(int y, int x)
////{
////    tableau[x, y] = "#";
////}
////void estDansCercle(int a, int b, double r)
////{
////    for (double y = 0; y < 50; y += 0.5)
////    {
////        for (double x = 0; x < 100; x += 0.5)
////        {
////            //if( ((x-a)*(x-a))+((y-b)*(y-b)) == (r*r))
////            //{
////            //    dessineCercle((int)y,(int)x);
////            //}
////            if ((x * x) + (y * y) - (2 * (a * x)) - (2 * (b * y)) + ((a * a) + (b * b) - (r * r)) == 0)
////            {
////                dessineCercle((int)y, (int)x);
////            }
////        }
////    }
////}
////creerTableau(100, 50);
////estDansCercle(20, 20, 20);
////afficherTableau(100, 50);

//// --------------------------FIN PAS BON

////string[,] tableau = new string[100, 50];

////void CreerTableau(int l, int h)
////{
////    for (int i = 0; i < h; i++)
////    {
////        for (int j = 0; j < l; j++)
////        {
////            tableau[j, i] = " ";
////        }
////    }
////}

////void AfficherTableau(int l, int h)
////{
////    for (int i = 0; i < h; i++)
////    {
////        for (int j = 0; j < l; j++)
////        {
////            Console.Write(tableau[j, i]);
////        }
////        Console.WriteLine();
////    }
////}

////void DessineCercle(int a, int b, int r)
////{
////    double rapport = 0.5;
////    double seuil = r/1.5;
////    for (int y = 0; y < 50; y++)
////    {
////        for (int x = 0; x < 100; x++)
////        {
////            double distanceCarre = Math.Pow((x - a) * rapport, 2) + Math.Pow(y - b, 2);
////            // Vérifier si le point (x, y) est à l'intérieur du cercle
////            if (Math.Abs(distanceCarre - Math.Pow(r, 2)) <= seuil )
////            {
////                tableau[x, y] = ".";
////            }
////        }
////    }
////}

//////Initialisation et dessin du cercle
////CreerTableau(100, 50);
////DessineCercle(50, 25, 15); // Centre (50,25) avec un rayon de 20
////AfficherTableau(100, 50);


//// ex 23
////Console.WriteLine("Rentrez date au format jj/mm/yyyy");
////string maDate = Console.ReadLine();

////DateTime maDateD = DateTime.Parse(maDate);

////Console.WriteLine(maDateD);

//// ex 24
//void question24()
//{
//    int nbATrouver = RandomNumberGenerator.GetInt32(-100,100);
//    string userNbS;
//    int userNb;
//    int counter = 1;

//    Console.WriteLine("Devine le nombre(int) : ");
//    userNbS = Console.ReadLine();
//    userNb = Int32.Parse(userNbS);

//    while (nbATrouver != userNb)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Ce n'est pas le bon nombre");
//        Console.ForegroundColor = ConsoleColor.White;
//        if (userNb < nbATrouver)
//        {
//            Console.WriteLine("Ton nombre est trop petit");
//            Console.WriteLine("Quel est ta nouvelle supposition ?");
//            userNbS = Console.ReadLine();
//            userNb = Int32.Parse(userNbS);
//            counter++;
//        }
//        if (userNb > nbATrouver)
//        {
//            Console.ForegroundColor = ConsoleColor.Magenta;
//            Console.WriteLine("Ton nombre est trop grand");
//            Console.ForegroundColor = ConsoleColor.White;
//            Console.WriteLine("Quel est ta nouvelle supposition ?");
//            userNbS = Console.ReadLine();
//            userNb = Int32.Parse(userNbS);
//            counter++;
//        }
//    }
//    if (nbATrouver == userNb)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine($"BRAVO TU AS TROUVEE !!! en {counter} fois !");
//        Console.ResetColor();
//    }
//}

//// question24();

//// ex 25

//void question25()
//{
//    Console.WriteLine("Quel est ta phrase à mettre en majuscule ? ");
//    string maPhrase = Console.ReadLine();
//    Console.WriteLine("Et Voila ta phrase modifié !");
//    Console.WriteLine(maPhrase.ToUpper());
//}
//// question25();

//void question26()
//{
//    string hello = "Hello";
//    Console.WriteLine($"Nous avons le mot suivant '{hello}' modifions le! ");
//    for(int i = 0; i <= hello.Length; i++)
//    {
//        hello = hello.Replace('l', '1');
//    }
//    Console.ForegroundColor= ConsoleColor.Green;
//    Console.WriteLine($"Voila le mot pimpéeeeee !! {hello}");
//}

//// question26();

//void question27()
//{
//    Console.WriteLine("Veuillez rentrer un mot !");
//    string monMot = Console.ReadLine();
//    if (monMot.Contains('x'))
//    {
//        Console.WriteLine("Votre mot contient au moin un x");
//        Console.WriteLine("Comme montré ci dessous");
//    }
//    else
//    {
//        Console.WriteLine("votre mot ne contient pas de x");
//    }
//}

//// question27();

//void question28()
//{
//    Console.WriteLine("Veuillez renseigner une premier mot :");
//    string mot1 = Console.ReadLine();
//    Console.WriteLine("et un deuxieme ! ");
//    string mot2 = Console.ReadLine();

//    if (mot1.ToLower().Equals(mot2.ToLower()))
//    {
//        Console.WriteLine("Vos deux mots sont les memes !");
//    }
//    else
//    {
//        Console.WriteLine("Vos mots sont différents !");
//    }
//}
//// question28();

//void question29()
//{
//    Console.WriteLine( "Renseignez un mot : ");
//    string palindrome = Console.ReadLine();
//    double palindromeLenght = palindrome.Length;
//    string moitiePrec = "";
//    string moitieFin = "";
//    char charToRemove = ' ';
//    //for (int i = 0; i <= palindromeLenght;i++)
//    //{
//        for(int j = 0; j <= palindromeLenght/2; j++)
//        {
//            moitiePrec += palindrome[j];
//        }
//        for (int w = (int)palindromeLenght-1; w >= (palindromeLenght-1)/2; w--)
//        {
//            moitieFin += palindrome[w];
//        }
//    var moitieFinTemp = moitieFin.Replace(charToRemove.ToString(), "");
//    var moitieDebutTemp = moitiePrec.Replace(charToRemove.ToString(), "");
//    if (moitieFinTemp.ToLower().Equals(moitieDebutTemp.ToLower()))
//    {
//        Console.WriteLine("VOTRE CHAINE EST UN PALINDROME");
//    }
//    else
//    {
//        Console.WriteLine("Votre phrase est pas marrante");
//    }
//}
//// question29();

//void question30()
//{
//    string[] liste = new string[100];
//    for(int i = 0; i < 100; i++)
//    {
//        liste[i] = $"{i+1}";
//        if (((i+1)%3) == 0 && ((i+1)%5) == 0)
//        {
//            liste[i] = "FizzBuzz";
//        }
//        if (((i+1) % 3) == 0 && liste[i] != "FizzBuzz")
//        {
//            liste[i] = "Fizz";
//        }
//        if (((i + 1) % 5) == 0 && liste[i] != "FizzBuzz")
//        {
//            liste[i] = "Buzz";
//        }

//    }
//    for(int i = 0; i < 100; i++)
//    {
//        if ((i+1)%9 == 0)
//        {
//            Console.WriteLine(liste[i]);
//            Console.WriteLine(" ");
//        }
//        else
//        {
//            Console.WriteLine(liste[i]);
//        }
//    }

//}
//// question30();

////void question31()
////{
////    string[,] morpion =
////    {
////        { " # ", " # ", " # " },
////        { " # ", " # ", " # " },
////        { " # ", " # ", " # " }
////    };
////    void afficherMorpion()
////    {
////        for(int i = 0;i < 3;i++)
////        {
////            Console.Write(" " +  morpion[0,i]  + " ");
////            Console.Write("|");
////        }
////        Console.WriteLine();
////        Console.WriteLine("-----------------");
////        for (int i = 0; i < 3; i++)
////        {
////            Console.Write(" " +  morpion[1, i]  + " ");
////            Console.Write("|");
////        }
////        Console.WriteLine();
////        Console.WriteLine("-----------------");
////        for (int i = 0; i < 3; i++)
////        {
////            Console.Write(" " +  morpion[2, i] + " ");
////            Console.Write("|");
////        }
////        Console.WriteLine();
////    };
////    void demanderPosO()
////    {
////        Console.WriteLine("C'est au joueur 1 , ou jouer ? ( Position de 1à9)");
////        string posTemp = Console.ReadLine();
////        Console.WriteLine();
////        switch (posTemp)
////        {
////            case "1":
////                morpion[0, 0] = " O ";
////                break;
////            case "2":
////                morpion[0, 1] = " O ";
////                break;
////            case "3":
////                morpion[0, 2] = " O ";
////                break;
////            case "4":
////                morpion[1, 0] = " O ";
////                break;
////            case "5":
////                morpion[1, 1] = " O ";
////                break;
////            case "6":
////                morpion[1, 2] = " O ";
////                break;
////            case "7":
////                morpion[2, 0] = " O ";
////                break;
////            case "8":
////                morpion[2, 1] = " O ";
////                break;
////            case "9":
////                morpion[2, 2] = " O ";
////                break;

////        }
////        posTemp.Remove(0);
////    }
////    void demanderPosX()
////    {
////        Console.WriteLine("C'est au joueur 2 , ou jouer ? ( Position de 1à9)");
////        string posTemp = Console.ReadLine();
////        Console.WriteLine();
////        switch (posTemp)
////        {
////            case "1":
////                morpion[0, 0] = " X ";
////                break;
////            case "2":
////                morpion[0, 1] = " X ";
////                break;
////            case "3":
////                morpion[0, 2] = " X ";
////                break;
////            case "4":
////                morpion[1, 0] = " X ";
////                break;
////            case "5":
////                morpion[1, 1] = " X ";
////                break;
////            case "6":
////                morpion[1, 2] = " X ";
////                break;
////            case "7":
////                morpion[2, 0] = " X ";
////                break;
////            case "8":
////                morpion[2, 1] = " X ";
////                break;
////            case "9":
////                morpion[2, 2] = " X ";
////                break;

////        }
////        posTemp.Remove(0);
////    }
////    void checkWinLigneX()
////    {
////        string lineCheck1 = "";
////        string lineCheck2 = "";
////        string lineCheck3 = "";
////        string ligneWinX = "xxx";
////        for (int i = 0; i < 3; i++)
////        {
////            lineCheck1 += morpion[0, i];
////        }
////        for (int i = 0; i < 3; i++)
////        {
////            lineCheck2 += morpion[1, i];
////        }
////        for (int i = 0; i < 3; i++)
////        {
////            lineCheck3 += morpion[2, i];
////        }
////        lineCheck1.Replace('#', ' ');
////        lineCheck1.Trim();
////        lineCheck2.Replace('#', ' ');
////        lineCheck2.Trim();
////        lineCheck3.Replace('#', ' ');
////        lineCheck3.Trim();
////        if (lineCheck1.ToLower() == ligneWinX) 
////        {
////            Console.WriteLine("LES X ONT GAGNEE !!!");
////        }
////        if (lineCheck2.ToLower() == ligneWinX)
////        {
////            Console.WriteLine("LES X ONT GAGNEE !!!");
////        }
////        if (lineCheck3.ToLower() == ligneWinX)
////        {
////            Console.WriteLine("LES X ONT GAGNEE !!!");
////        }

////    }
////    void tour(int x)
////    {
////        if(x%2 == 0)
////        {
////            Console.Clear();
////            afficherMorpion();
////            demanderPosX();
////            Console.Clear();
////            afficherMorpion();
////            checkWinLigneX();
////        }
////        else 
////        {
////            Console.Clear();
////            afficherMorpion();
////            demanderPosO();
////            Console.Clear();
////            afficherMorpion();
////            checkWinLigneX();
////        }
////        checkWinLigneX();
////    }
////    for(int i = 1; i <= 8; i++)
////    {
////        tour(i);
////    }

////}
////question31();


//// See https://aka.ms/new-console-template for more information




//string[,] morpionDisplay =
//{
//    { " ", " ", " " },
//    { " ", " ", " " },
//    { " ", " ", " " }
//};

//int[,] morpionInt = {
//    { 0, 0, 0 },
//    { 0, 0, 0 },
//    { 0, 0, 0 }
//};

//void actualiserDisplay()
//{
//    for (int i = 0; i <= 2; i++)
//    {
//        void actualiserLigne(int x)
//        {
//            if (morpionInt[x, i] == 1)
//            {
//                morpionDisplay[x, i] = "X";
//            }
//            if (morpionInt[x, i] == 2)
//            {
//                morpionDisplay[x, i] = "O";
//            }
//        }
//        actualiserLigne(0);
//        actualiserLigne(1);
//        actualiserLigne(2);
//    }
//}

//void afficherDisplay()
//{
//    void afficherLigne(int x)
//    {
//        for (int i = 0; i <= 2; i++)
//        {
//            actualiserDisplay();
//            if (i == 1) { Console.Write("| " + morpionDisplay[x, i] + " |"); }
//            else
//            {
//                Console.Write(" " + morpionDisplay[x, i] + " ");
//            }

//        }
//    }
//    afficherLigne(0);
//    Console.WriteLine();
//    Console.WriteLine("---|---|---");
//    afficherLigne(1);
//    Console.WriteLine();
//    Console.WriteLine("---|---|---");
//    afficherLigne(2);
//    Console.WriteLine();

//}

//int demanderPosition(int joueurCours)
//{
//    string positionS = "";
//    int positionN = 0;
//    if (joueurCours == 1)
//    {
//        Console.ForegroundColor = ConsoleColor.Yellow;
//        Console.WriteLine("---------------------------------------------------------------------------------------");
//        Console.WriteLine("-------------------------------------JOUEUR 1 JOUE-------------------------------------");
//        Console.WriteLine("---------------------------------------------------------------------------------------");
//        Console.ResetColor();
//    }
//    else if (joueurCours == 2)
//    {
//        Console.ForegroundColor = ConsoleColor.Cyan;
//        Console.WriteLine("---------------------------------------------------------------------------------------");
//        Console.WriteLine("-------------------------------------JOUEUR 2 JOUE-------------------------------------");
//        Console.WriteLine("---------------------------------------------------------------------------------------");
//        Console.ResetColor();
//    }
//    Console.WriteLine("Veuillez saisir le numéro que vous souhaitez jouer en suivant le tableau ci dessous :");
//    Console.WriteLine(" 1  2  3  \n 4  5  6  \n 7  8  9  ");
//    positionS = Console.ReadLine();
//    positionN = Int32.Parse(positionS);
//    return positionN;
//}

//void changerPion(int joueurEnCours, int place)
//{

//    if (joueurEnCours == 1)
//    {
//        if (place <= 3)
//        {
//            morpionInt[0, place - 1] = 1;
//        }
//        if (place >= 4 && place <= 6)
//        {
//            morpionInt[1, (place - 4)] = 1;
//        }
//        if (place >= 7 && place <= 9)
//        {
//            morpionInt[2, (place - 7)] = 1;
//        }
//    }
//    else if (joueurEnCours == 2)
//    {
//        if (place <= 3)
//        {
//            morpionInt[0, place - 1] = 2;
//        }
//        if (place >= 4 && place <= 6)
//        {
//            morpionInt[1, (place - 4)] = 2;
//        }
//        if (place >= 7 && place <= 9)
//        {
//            morpionInt[2, (place - 7)] = 2;
//        }
//    }
//}

//bool checkVictoireHorizontale(int joueur)
//{
//    bool checkLigne(int x, int joueurChoisis)
//    {
//        //if(morpionInt[x,1]*morpionInt[x, 2]* morpionInt[x, 0] == 1)
//        //{
//        //    return true;
//        //}
//        //if (morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0] == 1)
//        //{
//        //    return true;
//        //}
//        //if (morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0] == 1)
//        //{
//        //    return true;
//        //}
//        bool morpionVictoireX = ((morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0]) == 1);
//        bool morpionVictoireY = ((morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0]) == 8);
//        if (joueurChoisis == 1)
//        {
//            if (morpionVictoireX)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        if (joueurChoisis == 2)
//        {
//            if (morpionVictoireY)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        return false;


//    }
//    if (checkLigne(0, joueur))
//    {
//        return true;
//    }
//    if (checkLigne(1, joueur))
//    {
//        return true;
//    }
//    if (checkLigne(2, joueur))
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

//bool checkVictoireVerticale(int joueur)
//{
//    bool checkLigne(int x, int joueurChoisis)
//    {
//        //if(morpionInt[x,1]*morpionInt[x, 2]* morpionInt[x, 0] == 1)
//        //{
//        //    return true;
//        //}
//        //if (morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0] == 1)
//        //{
//        //    return true;
//        //}
//        //if (morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0] == 1)
//        //{
//        //    return true;
//        //}
//        bool morpionVictoireX = (morpionInt[0, x] * morpionInt[1, x] * morpionInt[2, x] == 1);
//        bool morpionVictoireY = (morpionInt[0, x] * morpionInt[1, x] * morpionInt[2, x] == 8);
//        if (joueurChoisis == 1)
//        {
//            if (morpionVictoireX)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        if (joueurChoisis == 2)
//        {
//            if (morpionVictoireY)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        return false;


//    }
//    if (checkLigne(0, joueur))
//    {
//        return true;
//    }
//    if (checkLigne(1, joueur))
//    {
//        return true;
//    }
//    if (checkLigne(2, joueur))
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

//bool checkVictoireDiagonale(int joueur)
//{
//    bool checkLigne(int x, int joueurChoisis)
//    {
//        //if(morpionInt[x,1]*morpionInt[x, 2]* morpionInt[x, 0] == 1)
//        //{
//        //    return true;
//        //}
//        //if (morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0] == 1)
//        //{
//        //    return true;
//        //}
//        //if (morpionInt[x, 1] * morpionInt[x, 2] * morpionInt[x, 0] == 1)
//        //{
//        //    return true;
//        //}
//        bool morpionVictoireX = (morpionInt[0, 0] * morpionInt[1, 1] * morpionInt[2, 2] == 1 || morpionInt[0, 2] * morpionInt[1, 1] * morpionInt[2, 0] == 1);
//        bool morpionVictoireY = (morpionInt[0, 0] * morpionInt[1, 1] * morpionInt[2, 2] == 8 || morpionInt[0, 2] * morpionInt[1, 1] * morpionInt[2, 0] == 8);
//        if (joueurChoisis == 1)
//        {
//            if (morpionVictoireX)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        if (joueurChoisis == 2)
//        {
//            if (morpionVictoireY)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        return false;


//    }
//    if (checkLigne(0, joueur))
//    {
//        return true;
//    }
//    if (checkLigne(1, joueur))
//    {
//        return true;
//    }
//    if (checkLigne(2, joueur))
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

//bool checkVictoire(int joueur)
//{
//    if (checkVictoireDiagonale(joueur) == true || checkVictoireHorizontale(joueur) == true || checkVictoireVerticale(joueur) == true)
//    {
//        return true;
//    }
//    else { return false; }
//}

//int tourCounter = 1;

//void tour()
//{
//    for (int i = 1; i < 10; i++)
//    {
//        actualiserDisplay();
//        if (i % 2 == 0)
//        {
//            Console.Clear();
//            actualiserDisplay();
//            afficherDisplay();
//            changerPion(2, demanderPosition(2));
//            actualiserDisplay();
//            tourCounter++;
//            if (checkVictoire(2))
//            {
//                Console.Clear();
//                Console.ForegroundColor = ConsoleColor.Green;
//                Console.WriteLine("--------------------------------------------------------------------------------------");
//                Console.WriteLine("-------------------------------------JOUEUR 2 GAGNE-----------------------------------");
//                Console.WriteLine("--------------------------------------------------------------------------------------");
//                Console.ResetColor();
//                break;
//            }
//            else
//            {
//                continue;
//            }
//        }
//        else
//        {
//            Console.Clear();
//            actualiserDisplay();
//            afficherDisplay();
//            changerPion(1, demanderPosition(1));
//            actualiserDisplay();
//            tourCounter++;
//            if (checkVictoire(1))
//            {
//                Console.Clear();
//                Console.ForegroundColor = ConsoleColor.Green;
//                Console.WriteLine("--------------------------------------------------------------------------------------");
//                Console.WriteLine("-------------------------------------JOUEUR 1 GAGNE-----------------------------------");
//                Console.WriteLine("--------------------------------------------------------------------------------------");
//                Console.ResetColor();
//                break;
//            }
//            else
//            {
//                continue;
//            }
//        }

//    }
//}
//tour();
//Console.WriteLine("Appuyez sur entrée pour fermer...");
//Console.ReadLine();




//using ConsoleApp7;
//// ******* test 
//    MaClasse v = new MaClasse();
//    string test = v.test;
//v.test = "tttt";
//    Console.WriteLine(test);

//namespace ConsoleApp7
//{
//    public class MaClasse()
//    {
//        public string test { get; } = "test";
//        public void testNom(string yes)
//        {
//            this.test = yes;
//        }
//    }

//}

//int y = 2;
//Console.WriteLine(y);
//int? z = null;

//y = z ?? -14;
//Console.WriteLine(y);
//z = 50;
//y = z ?? -14;
//Console.WriteLine(y);


bool i = false; 

if(i = true)
{
    Console.WriteLine(i);
}