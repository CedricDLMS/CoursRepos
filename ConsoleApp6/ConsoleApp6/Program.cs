namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> maListe = new List<int>();

            maListe.Add(1);

            void test(int x, ref int y)
            {
                x++;
                y++;
            }
            maListe.Add(10);
            Console.WriteLine(maListe[0]);
            Console.WriteLine(maListe[1]);

        }
    }
}
