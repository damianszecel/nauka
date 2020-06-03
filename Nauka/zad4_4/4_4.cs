/*Napisz program, który podaje, ile jest liczb pierwszych w tablicy 100 elementowej typu
int. Tablicę należy wypełnić losowymi wartościami. Wskazówka: Poniższy fragment
programu pokazuje działanie klasy Random (która zawiera generator liczb pseudolosowych) –
w pętli zostanie wyświetlonych 100 liczb wybranych losowo z zakresu 1 – 999 (o zakresie
decydują argumenty podane w wywołaniu metody Next()43).*/

using System;

namespace zad4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Ile liczb chcesz wylosowac?");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            int ilosc = 0;
            int[] tab2 = new int[n];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(3, 20);
            }
            for (int i = 0; i < tab.Length; i++)
            {
                bool x = true;
                for (int j = 2; j < tab[i]; j++)
                {
                    if (tab[i] % j == 0)
                    {
                        x = false;
                        break;
                    }

                }
                if (x && tab[i] > 2)
                {
                    tab2[ilosc] = tab[i];
                    ilosc++;
                }
            }
            if (ilosc > 0)
            {
                Console.WriteLine("W wylosowanym zbiorze znaleziono {0} liczb pierwszych", ilosc);
                for (int i = 0; i < ilosc; i++)
                {
                    Console.WriteLine("Liczba pierwsza z indeksem {0} wynosi {1}", i + 1, tab2[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
