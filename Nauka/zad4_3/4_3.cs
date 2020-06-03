using System;
using System.Security.Cryptography;

namespace zad4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj, ile chcesz wprowadzić liczb");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            int suma = 0;
            int min; int max; int nmin = 1; int nmax = 1; int dodatnie = 0;
            double srednia;
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Wprowadz {0} liczbe", i + 1);
                tab[i] = int.Parse(Console.ReadLine());
            }
            min = tab[0]; max = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                suma += tab[i];
                if (max < tab[i]) { max = tab[i]; nmax = i + 1; }
                if (min > tab[i]) { min = tab[i]; nmin = i + 1; }
                if (tab[i] > 0) dodatnie++;
            }
            srednia = (double)suma / tab.Length;
            Console.WriteLine("Pozycja numer {0} jest wartoscia maksymalna i wynosi {1}", nmax, max);
            Console.WriteLine("Pozycja numer {0} jest wartoscia minimalna i wynosi {1}", nmin, min);
            Console.WriteLine("Srednia wszystkich elementow wynosi {0}", srednia);
            Console.WriteLine("Wprowadzono {0} dodatnich liczb", dodatnie);
            Console.WriteLine(tab.Length);
            Console.ReadKey();
        }
    }
}
