/*Dana jest n-elementowa tablica liczb całkowitych tab1. Napisz program kopiujący
wartości elementów tablicy tab1 do tablicy tab2 (o tym samym rozmiarze) z przesunięciem o
jedną pozycje. To znaczy, że element w tablicy źródłowej o indeksie 0 powinien znaleźć się w
tablicy docelowej pod indeksem 1, element o indeksie 1 ma być w tablicy docelowej pod
indeksem 2 itd. Element ostatni tablicy źródłowej ma być elementem o indeksie 0 w tablicy
docelowej.*/

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
