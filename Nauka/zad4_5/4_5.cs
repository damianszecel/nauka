using System;
using System.Globalization;

namespace _4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile liczb chcesz wylosować?");
            int n = int.Parse(Console.ReadLine());
            int[] tab1 = new int[n];
            int[] tab2 = new int[n];
            Random liczba = new Random();
            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = liczba.Next(1, 300);
            }
            int x = 0;
            for (int j = tab2.Length; j > 0; j--)
            {
                tab2[j - 1] = tab1[tab1.Length - j];
                x++;
            }
            Console.Write("Wypiszemy liczby z pierwszego zbioru: ");
            foreach (int m in tab1)
            {
                Console.Write("{0} , ", m);
            }
            Console.WriteLine();
            Console.Write("Wypiszemy liczby z drugiego zbioru ");
            foreach (int l in tab2)
            {
                Console.Write("{0} , ", l);
            }
            Console.ReadKey();
        }
    }
}
