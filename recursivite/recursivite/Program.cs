// See https://aka.ms/new-console-template for more information
DirectoryInfo fichierSource = new DirectoryInfo(@"C:\Users\DIGINAMIC\Pictures\");
string acces = @fichierSource.FullName;
listerDossier(acces, 0);
void listerDossier(string path, int niveau)
{
    //int nbPoints = 0;
    //char point = '-';
    string edentation = new string('.', niveau * 2);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(edentation + Path.GetFileName(path));

    foreach (var items in Directory.GetFiles(path))
    {
        Console.ForegroundColor= ConsoleColor.Blue;
        Console.WriteLine(edentation + "."+ Path.GetFileName(items));
    }
    foreach (var item in Directory.GetDirectories(path))
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(item);
        if (directoryInfo.Attributes.HasFlag(FileAttributes.Hidden))
            continue;
        listerDossier(item, niveau + 1);
    }

}

//listerDossier(fichierSource);
//AfficherDossiersEtFichiers(@"C:\Users\DIGINAMIC\source\repos\DOSSIER TEST", 0);

//static void AfficherDossiersEtFichiers(string chemin, int niveau)
//{
//    // Affiche le dossier courant
//    string indentation = new String(' ', niveau * 2);
//    Console.WriteLine($"{indentation}{Path.GetFileName(chemin)}");

//    // Récupère tous les sous-dossiers
//    foreach (var sousDossier in Directory.GetDirectories(chemin))
//    {
//        AfficherDossiersEtFichiers(sousDossier, niveau + 1);
//    }

//    // Récupère et affiche tous les fichiers du dossier courant
//    foreach (var fichier in Directory.GetFiles(chemin))
//    {
//        Console.WriteLine($"{indentation}  {Path.GetFileName(fichier)}");
//    }

//}
