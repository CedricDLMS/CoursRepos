using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asynchronite
{
    public class FileHelp()
    {
        // en synchrone
        public static void ecrire(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            Console.WriteLine("Que souhaitez vous ecrire dans le fichier ? " + directoryInfo.Name);
            string texte = Console.ReadLine() + " ";

            var FileStream = new FileStream(path, FileMode.Create);

            byte[] buffer = Encoding.UTF8.GetBytes(texte);
            FileStream.Write(buffer);
            FileStream.Close();
        }
        public static void afficher(string path)
        {
            using(StreamReader reader = new StreamReader(path))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("Nous avons le contenue suivant dans : " + path);
                Console.WriteLine(content);
            }
        }

        // en asynchrone

        public static async Task EcrireAsync(string path)
        {
            Console.WriteLine($"Ecrire dans : {path}");
            string contenu = Console.ReadLine() + " ";
            await Task.Delay(5000);
            await File.WriteAllTextAsync(path, contenu);
            Console.WriteLine("Ecriture fini");
        }
        public static async Task AfficherAsync(string path)
        {
            string contenu = await File.ReadAllTextAsync(path);
            Console.WriteLine($"Nous avons dans {path} : {contenu}");
        }

    }
}
