/*Napisz program analizujący częstość występowania poszczególnych znaków w
łańcuchu znaków wprowadzonym przez użytkownika.Np.dla wprowadzonego tekstu
„abrakadabra” program powinien wyświetlić informacje: a – 5, b – 2, r – 2, k – 1, d – 1.*/

using System;

namespace zad4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 50;
            Console.WriteLine("Wprowadz tekst do przeanalizowania");
            string x = Console.ReadLine();
            int n1 = x.Length;
            if (n1 < n) { n = n1; }
            string[] tab = new string[n];
            int[] ilosc = new int[n];
            tab[0] = x.Substring(0, 1);
            ilosc[0] = 1;
            int z = 1; bool o;

            for (int i = 1; i < x.Length; i++)
            {
                o = true;
                for (int j = 0; j < i; j++)
                {
                    if (x.Substring(i, 1) == x.Substring(j, 1))
                    {
                        ilosc[j]++;
                        o = false;
                        break;
                    }
                }
                if (o)
                {
                    z++;
                    tab[z - 1] = x.Substring(i, 1);
                    ilosc[z - 1]++;
                }
            }
            for (int k = 0; k < z; k++)
            {
                Console.WriteLine("Liczba znakow {0} wynosi {1}", tab[k], ilosc[k]);
            }
            Console.ReadKey();

        }
    }
}