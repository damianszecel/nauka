using System;

namespace Tab_met
{
    public class Zmianaliter
    {
        public static void Main(string[] args)
        {
            string[] tab1 = { "damian", "nikola" };
            Zmiana(tab1);
            for (int i = 0; i < tab1.Length ; i++)
            {
                Console.WriteLine("Wartosc {0}" , tab1[i]);
            }
            Console.ReadKey();
        }

        public static void Zmiana(string[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = tab[i].ToUpper();
            }
        }
    }
}
